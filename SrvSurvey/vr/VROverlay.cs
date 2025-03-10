using System.Numerics;
using OVRSharp;
using OVRSharp.Math;
using System.Drawing.Imaging;
using SharpDX;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using Device = SharpDX.Direct3D11.Device;
using Valve.VR;

namespace SrvSurvey.vr
{
    public class VROverlay : OVRSharp.Application
    {
        private Overlay? overlay;
        private Device device;
        private Form form;
        private Texture2D? texture;
        // private Bitmap bitmap;

        public VROverlay(Form form) : base(ApplicationType.Overlay)
        {
            device = new Device(DriverType.Hardware, DeviceCreationFlags.BgraSupport);
            overlay = new Overlay($"SrvSurvey {form.Name}[{form.Handle}]", $"SrvSurvey {form.Name}[{form.Handle}]");
            overlay.WidthInMeters = 1f;
            overlay.Show();

            this.form = form;
            form.Paint += FormPaint;
            form.Move += FormMove;
            form.FormClosed += FormOnFormClosed;
            // bitmap = new Bitmap(form.ClientSize.Width, form.ClientSize.Height);
        }

        private void FormOnFormClosed(object? sender, FormClosedEventArgs e)
        {
            overlay?.Hide();
            overlay = null;
        }

        private void FormMove(object? sender, EventArgs e)
        {
            float radians = 0;// (float)((Math.PI / 180) * 90);
            var rotation = Matrix4x4.CreateRotationX(radians);
            var scale = 0.002f;
            var translation = Matrix4x4.CreateTranslation(scale * (form.Left - Screen.PrimaryScreen.Bounds.Width / 2), -scale * (form.Top - Screen.PrimaryScreen.Bounds.Height / 2) + 1f, -3);
            var transform = Matrix4x4.Multiply(rotation, translation);
            overlay.Transform = transform.ToHmdMatrix34_t();
        }

        private void FormPaint(object? sender, PaintEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            // texture = CaptureFormToTexture();
            UpdateOverlay();
        }

        private void UpdateTexture()
        {
            var withNonClientArea = new Bitmap(form.Width, form.Height);
            form.DrawToBitmap(withNonClientArea, new Rectangle(0, 0, form.Width, form.Height));

            var screenPoint = form.PointToScreen(Point.Empty);
            var bitmap = new Bitmap(form.ClientSize.Width, form.ClientSize.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(withNonClientArea, 0, 0,
                    new Rectangle(screenPoint.X - form.Location.X, screenPoint.Y - form.Location.Y,
                        bitmap.Width, bitmap.Height),
                    GraphicsUnit.Pixel);
            }

            withNonClientArea.Dispose();

            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var data = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                // if (texture == null)
                {
                    var textureDesc = new Texture2DDescription
                    {
                        Width = bitmap.Width,
                        Height = bitmap.Height,
                        MipLevels = 1,
                        ArraySize = 1,
                        Format = Format.B8G8R8A8_UNorm,
                        SampleDescription = new SampleDescription(1, 0),
                        Usage = ResourceUsage.Immutable,
                        BindFlags = BindFlags.ShaderResource,
                        CpuAccessFlags = CpuAccessFlags.None,
                        OptionFlags = ResourceOptionFlags.None
                    };

                    DataRectangle dataRect = new DataRectangle(data.Scan0, data.Stride);

                    texture = new Texture2D(device, textureDesc, new[] { dataRect });
                }
            }
            finally
            {
                bitmap.UnlockBits(data);
            }
        }

        private void UpdateOverlay()
        {
            UpdateTexture();
            if (texture == null) return;

            var overlayTex = new Texture_t()
            {
                eColorSpace = EColorSpace.Auto,
                eType = ETextureType.DirectX,
                handle = texture.NativePointer
            };
            overlay.SetTexture(overlayTex);
            device.ImmediateContext.Flush();
        }
    }
}