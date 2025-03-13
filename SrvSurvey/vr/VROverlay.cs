using System.Numerics;
using OVRSharp;
using OVRSharp.Math;
using System.Drawing.Imaging;
using SharpDX;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpDX.D3DCompiler;
using Device = SharpDX.Direct3D11.Device;
using Valve.VR;
using Buffer = SharpDX.Direct3D11.Buffer;
using System.Runtime.InteropServices;
using SrvSurvey.plotters;
using SrvSurvey.game;

namespace SrvSurvey.vr
{
    public class VROverlay : OVRSharp.Application
    {
        // Default to setting's value, but can be adjusted without clobbering the setting
        public static bool displayVR = Game.settings.displayVR;

        private Overlay? overlay;
        private Device device;
        private Size size;
        private int top;
        private int left;
        Bitmap? bitmap;
        private DeviceContext context;
        private Texture2D texture;
        private Texture_t overlayTex;
        private PlotPos? lastPlotPos;
        private bool visible;

        public VROverlay(string uniqueId) : base(ApplicationType.Overlay)
        {
            device = new Device(DriverType.Hardware, DeviceCreationFlags.BgraSupport);
            context = device.ImmediateContext;

            overlay = new Overlay(uniqueId, uniqueId);
            // overlay.SetTextureFromFile(@"e:\dev\screen.png");
            overlay.WidthInMeters = 1f;
        }

        private void UpdateSize(PlotBase form)
        {
            if (this.bitmap == null || this.size != form.Size || this.top != form.Top || this.left != form.Left)
            {
                if (Screen.PrimaryScreen == null) return;

                this.size = form.Size;
                this.top = form.Top;
                this.left = form.Left;

                bitmap = new Bitmap(this.size.Width, this.size.Height);
                var textureDesc = new Texture2DDescription
                {
                    Width = bitmap.Width,
                    Height = bitmap.Height,
                    MipLevels = 1,
                    ArraySize = 1,
                    Format = Format.B8G8R8A8_UNorm,
                    SampleDescription = new SampleDescription(1, 0),
                    //Usage = ResourceUsage.Immutable,
                    Usage = ResourceUsage.Default,
                    BindFlags = BindFlags.ShaderResource,
                    CpuAccessFlags = CpuAccessFlags.None,
                    OptionFlags = ResourceOptionFlags.None
                };
                texture = new Texture2D(device, textureDesc);
                overlayTex = new Texture_t()
                {
                    eColorSpace = EColorSpace.Auto,
                    eType = ETextureType.DirectX,
                    handle = texture.NativePointer
                };
            }
        }

        internal void Update(PlotBase form)
        {
            this.UpdateSize(form);
            if (bitmap == null || overlay == null) return; 

            if (form.Opacity == 0 || !form.Visible)
            {
                if (visible)
                {
                    visible = false;
                    overlay.Hide();
                }
            }
            else
            {
                if (!visible)
                {
                    visible = true;
                    overlay.Show();
                }
                overlay.Alpha = (float)form.Opacity;
            }

            if (!visible)
            {
                return;
            }
            
            form.DrawToBitmap(bitmap, new Rectangle(0, 0, this.size.Width, this.size.Height));

            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var data = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                DataBox dataBox = new DataBox(data.Scan0, data.Stride, 0);
                var region = new ResourceRegion
                {
                    Left = 0,
                    Top = 0,
                    Front = 0,
                    Right = bitmap.Width,
                    Bottom = bitmap.Height,
                    Back = 1
                };                    
                context.UpdateSubresource(dataBox, texture, 0, region);
                context.Flush();
                overlay.SetTexture(overlayTex);
            }
            finally
            {
                bitmap.UnlockBits(data);
            }
            
            var pp = PlotPos.get(form.Name);
            if (pp == null || lastPlotPos == pp) return; 
            
            var rotation = pp.vrRotation;
            // yaw = Y, pitch = X, roll = Z - the Y and X really should be swapped like this  
            var rot = Matrix4x4.CreateFromYawPitchRoll(MathF.PI / 180 * rotation.Y, 
                MathF.PI / 180 * rotation.X, MathF.PI / 180 * rotation.Z);
            
            // divide by 10 to avoid decimals on the fomrs
            var pos = Matrix4x4.CreateTranslation(
                new Vector3(pp.vrPosition.X / 10, pp.vrPosition.Y / 10, -pp.vrPosition.Z / 10));
            var sc = Matrix4x4.CreateScale(pp.vrScale / 10); // yes 10
            
            var tr = Matrix4x4.Multiply(rot, sc);
            tr = Matrix4x4.Multiply(tr, pos);

            this.overlay.Transform = tr.ToHmdMatrix34_t();
        }

        public void Close()
        {
            if (overlay != null)
            {
                overlay.Hide();
                overlay = null;
            }
        }
    }
}