﻿using SrvSurvey.game;
using SrvSurvey.vr;
using SrvSurvey.widgets;
using System.ComponentModel;
// Currently, this does not require any localization

namespace SrvSurvey.plotters
{
    [ApproxSize(240, 80)]
    internal class PlotAdjustVR : PlotBase, PlotterForm
    {
        public static bool allowPlotter
        {
            get => VROverlay.displayVR
                && forceShow;
        }

        /// <summary> When true, makes the plotter become visible </summary>
        public static bool forceShow = false;

        private string targetName;
        private int idx;
        private Mode mode;

        private int x, y, z;
        private int vrScale;
        private int yaw, pitch, roll;

        private PlotAdjustVR() : base()
        {
            this.Size = Size.Empty;
            this.Font = GameColors.Fonts.console_8;
            KeyboardHook.buttonsPressed += KeyboardHook_buttonsPressed;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            KeyboardHook.buttonsPressed -= KeyboardHook_buttonsPressed;
        }

        public override bool allow { get => PlotAdjustVR.allowPlotter; }

        protected override void OnLoad(EventArgs e)
        {
            this.Width = scaled(400);
            this.Height = scaled(300);

            base.OnLoad(e);

            this.initializeOnLoad();
            this.reposition(Elite.getWindowRect(true));

            KeyboardHook.redirect = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            KeyboardHook.redirect = false;
            PlotAdjustVR.forceShow = false;
        }

        private void KeyboardHook_buttonsPressed(bool hook, string chord)
        {
            // only process when buttons are released
            if (!hook) return;

            Game.log(chord);

            if (chord == "B1") // Btn B
            {
                this.Close();
            }
            else if (chord == "B0") // Btn A
            {
                // commit changes
                // TODO: ...
            }
            else if (chord == "B2") // Btn X
            {
                // next overlay
                this.idx++;
            }
            else if (chord == "B3") // Btn Y
            {
                // next mode: position / rotation / scale
                this.mode++;
                if (this.mode > Mode.scale) this.mode = Mode.position;
            }

            if (this.mode == Mode.position)
            {
                if (chord == "PovU") this.y--;
                else if (chord == "PovD") this.y++;
                else if (chord == "PovL") this.x--;
                else if (chord == "PovR") this.x++;
                else if (chord == "B4") this.z--; // left bumper
                else if (chord == "B5") this.z++; // right bumper

                // TODO: adjust the plotter
            }
            else if (this.mode == Mode.rotation)
            {
                if (chord == "PovU") this.pitch--;
                else if (chord == "PovD") this.pitch++;
                else if (chord == "PovL") this.yaw--;
                else if (chord == "PovR") this.yaw++;
                else if (chord == "B4") this.roll--; // left bumper
                else if (chord == "B5") this.roll++; // right bumper

                // TODO: adjust the plotter
            }
            else if (this.mode == Mode.scale)
            {
                if (chord == "PovU") this.vrScale++;
                else if (chord == "PovD") this.vrScale--;

                if (this.vrScale < 1) this.vrScale = 1;

                // TODO: adjust the plotter
            }

            this.Invalidate();
        }

        protected override void onPaintPlotter(PaintEventArgs e)
        {
            // get plotter names and keep idx value legal
            var names = Program.getAllPlotterNames();
            if (this.idx >= names.Length) this.idx = 0;
            if (this.idx < 0) this.idx = names.Length - 1;
            this.targetName = names[idx];

            // draw which overlays exist + which is selected
            drawTextAt2(two, "Overlay:");
            newLine(+four, true);
            for (var n = 0; n < names.Length; n++)
            {
                if (n == this.idx)
                    drawTextAt2(two, $"> {names[n]} <", C.cyan);
                else
                    drawTextAt2(two, $"  {names[n]} ");

                newLine(+four, true);
            }

            dty += ten;
            drawTextAt2(two, $"Adjust Position: ");
            drawTextAt2($"{mode}", C.cyan);
            newLine(+ten, true);

            var controlHint = "";
            if (this.mode == Mode.position)
                controlHint = this.drawAdjustPosition();
            else if (this.mode == Mode.rotation)
                controlHint = this.drawAdjustRotation();
            else if (this.mode == Mode.scale)
                controlHint = this.drawAdjustScale();

            dty += ten;
            drawTextAt2(ten, "To adjust:");
            newLine(+four, true);
            drawTextAt2(ten, controlHint);
            newLine(+ten, true);
            drawTextAt2(ten, "Press:");
            newLine(+four, true);
            drawTextAt2(ten, "X to cycle overlay");
            newLine(true);
            drawTextAt2(ten, "Y to cycle: position > rotation > scale");
            newLine(true);
            drawTextAt2(ten, "A to commit | B to cancel");
            newLine(true);

            // Resize the plotter? Probably not?
            //this.formAdjustSize(+ten, +ten);
        }

        private string drawAdjustPosition()
        {
            drawTextAt2(ten, $"X: {this.x}");
            newLine(true);
            drawTextAt2(ten, $"Y: {this.y}");
            newLine(true);
            drawTextAt2(ten, $"Z: {this.z}");
            newLine(+ten, true);

            return "X: left/right | Y: up/down | Z: Bumpers";
        }

        private string drawAdjustRotation()
        {
            drawTextAt2(ten, $"yaw: {this.yaw}");
            newLine(true);
            drawTextAt2(ten, $"pitch: {this.pitch}");
            newLine(true);
            drawTextAt2(ten, $"roll: {this.roll}");
            newLine(+ten, true);

            return "YAW: left/right | PITCH: up/down | ROLL: bumpers";
        }

        private string drawAdjustScale()
        {
            drawTextAt2(ten, $"scale: {this.vrScale}");
            newLine(+ten, true);

            return "Bumpers to adjust scale";
        }

        enum Mode
        {
            position,
            rotation,
            scale
        }
    }
}
