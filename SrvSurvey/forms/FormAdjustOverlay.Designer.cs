namespace SrvSurvey.forms
{
    partial class FormAdjustOverlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblChoose = new Label();
            comboPlotter = new ComboBox();
            btnCancel = new Button();
            btnAccept = new Button();
            checkLeft = new CheckBox();
            checkCenter = new CheckBox();
            checkRight = new CheckBox();
            checkTop = new CheckBox();
            checkMiddle = new CheckBox();
            checkBottom = new CheckBox();
            labelOffset = new Label();
            numY = new NumericUpDown();
            numX = new NumericUpDown();
            groupBox1 = new GroupBox();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label3 = new Label();
            numVRScale = new NumericUpDown();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label1 = new Label();
            numVRX = new NumericUpDown();
            numVRY = new NumericUpDown();
            numVRZ = new NumericUpDown();
            flowLayoutPanel5 = new FlowLayoutPanel();
            checkOpacity = new CheckBox();
            numOpacity = new NumericUpDown();
            btnReset = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label2 = new Label();
            numVRYaw = new NumericUpDown();
            numVRPitch = new NumericUpDown();
            numVRRoll = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkHScreen = new CheckBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            checkVScreen = new CheckBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblAdvise = new Label();
            checkShowAll = new CheckBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVRScale).BeginInit();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVRX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVRY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVRZ).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOpacity).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVRYaw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVRPitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVRRoll).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.FlatStyle = FlatStyle.System;
            lblChoose.Location = new Point(12, 9);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(107, 15);
            lblChoose.TabIndex = 0;
            lblChoose.Text = "Choose &an overlay:";
            // 
            // comboPlotter
            // 
            comboPlotter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboPlotter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPlotter.FlatStyle = FlatStyle.System;
            comboPlotter.FormattingEnabled = true;
            comboPlotter.Items.AddRange(new object[] { "Choose an overlay..." });
            comboPlotter.Location = new Point(143, 6);
            comboPlotter.Name = "comboPlotter";
            comboPlotter.Size = new Size(300, 23);
            comboPlotter.TabIndex = 1;
            comboPlotter.DropDown += comboPlotter_DropDown;
            comboPlotter.SelectedIndexChanged += comboPlotter_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(84, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.DialogResult = DialogResult.OK;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(3, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "&Save";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // checkLeft
            // 
            checkLeft.AutoSize = true;
            checkLeft.FlatStyle = FlatStyle.System;
            checkLeft.Location = new Point(3, 3);
            checkLeft.Name = "checkLeft";
            checkLeft.Size = new Size(52, 20);
            checkLeft.TabIndex = 0;
            checkLeft.Tag = "Left";
            checkLeft.Text = "Left";
            checkLeft.UseVisualStyleBackColor = true;
            checkLeft.CheckedChanged += checkHorizontal_CheckedChanged;
            // 
            // checkCenter
            // 
            checkCenter.AutoSize = true;
            checkCenter.FlatStyle = FlatStyle.System;
            checkCenter.Location = new Point(61, 3);
            checkCenter.Name = "checkCenter";
            checkCenter.Size = new Size(67, 20);
            checkCenter.TabIndex = 1;
            checkCenter.Tag = "Center";
            checkCenter.Text = "Center";
            checkCenter.UseVisualStyleBackColor = true;
            checkCenter.CheckedChanged += checkHorizontal_CheckedChanged;
            // 
            // checkRight
            // 
            checkRight.AutoSize = true;
            checkRight.FlatStyle = FlatStyle.System;
            checkRight.Location = new Point(134, 3);
            checkRight.Name = "checkRight";
            checkRight.Size = new Size(60, 20);
            checkRight.TabIndex = 2;
            checkRight.Tag = "Right";
            checkRight.Text = "Right";
            checkRight.UseVisualStyleBackColor = true;
            checkRight.CheckedChanged += checkHorizontal_CheckedChanged;
            // 
            // checkTop
            // 
            checkTop.AutoSize = true;
            checkTop.FlatStyle = FlatStyle.System;
            checkTop.Location = new Point(3, 3);
            checkTop.Name = "checkTop";
            checkTop.Size = new Size(51, 20);
            checkTop.TabIndex = 0;
            checkTop.Tag = "Top";
            checkTop.Text = "Top";
            checkTop.UseVisualStyleBackColor = true;
            checkTop.CheckedChanged += checkVertical_CheckedChanged;
            // 
            // checkMiddle
            // 
            checkMiddle.AutoSize = true;
            checkMiddle.FlatStyle = FlatStyle.System;
            checkMiddle.Location = new Point(3, 29);
            checkMiddle.Name = "checkMiddle";
            checkMiddle.Size = new Size(69, 20);
            checkMiddle.TabIndex = 1;
            checkMiddle.Tag = "Middle";
            checkMiddle.Text = "Middle";
            checkMiddle.UseVisualStyleBackColor = true;
            checkMiddle.CheckedChanged += checkVertical_CheckedChanged;
            // 
            // checkBottom
            // 
            checkBottom.AutoSize = true;
            checkBottom.FlatStyle = FlatStyle.System;
            checkBottom.Location = new Point(3, 55);
            checkBottom.Name = "checkBottom";
            checkBottom.Size = new Size(72, 20);
            checkBottom.TabIndex = 2;
            checkBottom.Tag = "Bottom";
            checkBottom.Text = "Bottom";
            checkBottom.UseVisualStyleBackColor = true;
            checkBottom.CheckedChanged += checkVertical_CheckedChanged;
            // 
            // labelOffset
            // 
            labelOffset.Anchor = AnchorStyles.Right;
            labelOffset.AutoSize = true;
            labelOffset.FlatStyle = FlatStyle.System;
            labelOffset.Location = new Point(3, 7);
            labelOffset.Name = "labelOffset";
            labelOffset.Size = new Size(65, 15);
            labelOffset.TabIndex = 0;
            labelOffset.Text = "&Offset X, Y:";
            // 
            // numY
            // 
            numY.Location = new Point(130, 3);
            numY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numY.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numY.Name = "numY";
            numY.Size = new Size(50, 23);
            numY.TabIndex = 2;
            numY.TextAlign = HorizontalAlignment.Right;
            numY.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            numY.ValueChanged += num_ValueChanged;
            // 
            // numX
            // 
            numX.Location = new Point(74, 3);
            numX.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numX.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numX.Name = "numX";
            numX.Size = new Size(50, 23);
            numX.TabIndex = 1;
            numX.TextAlign = HorizontalAlignment.Right;
            numX.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            numX.ValueChanged += num_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(flowLayoutPanel8);
            groupBox1.Controls.Add(flowLayoutPanel6);
            groupBox1.Controls.Add(flowLayoutPanel5);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(flowLayoutPanel4);
            groupBox1.Controls.Add(flowLayoutPanel7);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Location = new Point(15, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 234);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel8.Controls.Add(label3);
            flowLayoutPanel8.Controls.Add(numVRScale);
            flowLayoutPanel8.Location = new Point(128, 199);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(126, 29);
            flowLayoutPanel8.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            label3.Text = "&VR Scale %";
            // 
            // numVRScale
            // 
            numVRScale.Enabled = false;
            numVRScale.Location = new Point(73, 3);
            numVRScale.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRScale.Name = "numVRScale";
            numVRScale.Size = new Size(50, 23);
            numVRScale.TabIndex = 1;
            numVRScale.TextAlign = HorizontalAlignment.Right;
            numVRScale.Value = new decimal(new int[] { 99, 0, 0, 0 });
            numVRScale.ValueChanged += numVrScale_ValueChanged;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.Controls.Add(label1);
            flowLayoutPanel6.Controls.Add(numVRX);
            flowLayoutPanel6.Controls.Add(numVRY);
            flowLayoutPanel6.Controls.Add(numVRZ);
            flowLayoutPanel6.Location = new Point(130, 129);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(269, 29);
            flowLayoutPanel6.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "&VR Offset X, Y, Z:";
            // 
            // numVRX
            // 
            numVRX.Enabled = false;
            numVRX.Location = new Point(104, 3);
            numVRX.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRX.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numVRX.Name = "numVRX";
            numVRX.Size = new Size(50, 23);
            numVRX.TabIndex = 1;
            numVRX.TextAlign = HorizontalAlignment.Right;
            numVRX.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRX.ValueChanged += numVrOffset_ValueChanged;
            // 
            // numVRY
            // 
            numVRY.Enabled = false;
            numVRY.Location = new Point(160, 3);
            numVRY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRY.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numVRY.Name = "numVRY";
            numVRY.Size = new Size(50, 23);
            numVRY.TabIndex = 2;
            numVRY.TextAlign = HorizontalAlignment.Right;
            numVRY.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRY.ValueChanged += numVrOffset_ValueChanged;
            // 
            // numVRZ
            // 
            numVRZ.Enabled = false;
            numVRZ.Location = new Point(216, 3);
            numVRZ.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRZ.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numVRZ.Name = "numVRZ";
            numVRZ.Size = new Size(50, 23);
            numVRZ.TabIndex = 3;
            numVRZ.TextAlign = HorizontalAlignment.Right;
            numVRZ.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            numVRZ.ValueChanged += numVrOffset_ValueChanged;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(checkOpacity);
            flowLayoutPanel5.Controls.Add(numOpacity);
            flowLayoutPanel5.Location = new Point(130, 94);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(182, 23);
            flowLayoutPanel5.TabIndex = 5;
            // 
            // checkOpacity
            // 
            checkOpacity.Anchor = AnchorStyles.Right;
            checkOpacity.AutoSize = true;
            checkOpacity.FlatStyle = FlatStyle.System;
            checkOpacity.Location = new Point(0, 1);
            checkOpacity.Margin = new Padding(0);
            checkOpacity.Name = "checkOpacity";
            checkOpacity.Size = new Size(132, 20);
            checkOpacity.TabIndex = 4;
            checkOpacity.Tag = "Top";
            checkOpacity.Text = "Override opacity %";
            checkOpacity.UseVisualStyleBackColor = true;
            checkOpacity.CheckedChanged += checkOpacity_CheckedChanged;
            // 
            // numOpacity
            // 
            numOpacity.Enabled = false;
            numOpacity.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numOpacity.Location = new Point(132, 0);
            numOpacity.Margin = new Padding(0);
            numOpacity.Name = "numOpacity";
            numOpacity.Size = new Size(50, 23);
            numOpacity.TabIndex = 1;
            numOpacity.TextAlign = HorizontalAlignment.Right;
            numOpacity.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numOpacity.ValueChanged += numOpacity_ValueChanged;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.AutoSize = true;
            btnReset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReset.Location = new Point(380, 203);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(45, 25);
            btnReset.TabIndex = 3;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(labelOffset);
            flowLayoutPanel4.Controls.Add(numX);
            flowLayoutPanel4.Controls.Add(numY);
            flowLayoutPanel4.Location = new Point(131, 59);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(183, 29);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.Controls.Add(label2);
            flowLayoutPanel7.Controls.Add(numVRYaw);
            flowLayoutPanel7.Controls.Add(numVRPitch);
            flowLayoutPanel7.Controls.Add(numVRRoll);
            flowLayoutPanel7.Location = new Point(128, 164);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(289, 29);
            flowLayoutPanel7.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 0;
            label2.Text = "&VR Yaw, Pitch, Roll °:";
            // 
            // numVRYaw
            // 
            numVRYaw.Enabled = false;
            numVRYaw.Location = new Point(124, 3);
            numVRYaw.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            numVRYaw.Name = "numVRYaw";
            numVRYaw.Size = new Size(50, 23);
            numVRYaw.TabIndex = 1;
            numVRYaw.TextAlign = HorizontalAlignment.Right;
            numVRYaw.Value = new decimal(new int[] { 359, 0, 0, 0 });
            numVRYaw.ValueChanged += vrRotation_ValueChanged;
            // 
            // numVRPitch
            // 
            numVRPitch.Enabled = false;
            numVRPitch.Location = new Point(180, 3);
            numVRPitch.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            numVRPitch.Name = "numVRPitch";
            numVRPitch.Size = new Size(50, 23);
            numVRPitch.TabIndex = 2;
            numVRPitch.TextAlign = HorizontalAlignment.Right;
            numVRPitch.Value = new decimal(new int[] { 359, 0, 0, 0 });
            numVRPitch.ValueChanged += vrRotation_ValueChanged;
            // 
            // numVRRoll
            // 
            numVRRoll.Enabled = false;
            numVRRoll.Location = new Point(236, 3);
            numVRRoll.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            numVRRoll.Name = "numVRRoll";
            numVRRoll.Size = new Size(50, 23);
            numVRRoll.TabIndex = 3;
            numVRRoll.TextAlign = HorizontalAlignment.Right;
            numVRRoll.Value = new decimal(new int[] { 359, 0, 0, 0 });
            numVRRoll.ValueChanged += vrRotation_ValueChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(checkLeft);
            flowLayoutPanel1.Controls.Add(checkCenter);
            flowLayoutPanel1.Controls.Add(checkRight);
            flowLayoutPanel1.Controls.Add(checkHScreen);
            flowLayoutPanel1.Location = new Point(94, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(270, 26);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // checkHScreen
            // 
            checkHScreen.AutoSize = true;
            checkHScreen.FlatStyle = FlatStyle.System;
            checkHScreen.Location = new Point(200, 3);
            checkHScreen.Name = "checkHScreen";
            checkHScreen.Size = new Size(67, 20);
            checkHScreen.TabIndex = 3;
            checkHScreen.Tag = "OS";
            checkHScreen.Text = "Screen";
            checkHScreen.UseVisualStyleBackColor = true;
            checkHScreen.CheckedChanged += checkHorizontal_CheckedChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(checkTop);
            flowLayoutPanel2.Controls.Add(checkMiddle);
            flowLayoutPanel2.Controls.Add(checkBottom);
            flowLayoutPanel2.Controls.Add(checkVScreen);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(14, 48);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(78, 104);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // checkVScreen
            // 
            checkVScreen.AutoSize = true;
            checkVScreen.FlatStyle = FlatStyle.System;
            checkVScreen.Location = new Point(3, 81);
            checkVScreen.Name = "checkVScreen";
            checkVScreen.Size = new Size(67, 20);
            checkVScreen.TabIndex = 3;
            checkVScreen.Tag = "OS";
            checkVScreen.Text = "Screen";
            checkVScreen.UseVisualStyleBackColor = true;
            checkVScreen.CheckedChanged += checkVertical_CheckedChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(btnAccept);
            flowLayoutPanel3.Controls.Add(btnCancel);
            flowLayoutPanel3.Location = new Point(284, 337);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(162, 29);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // lblAdvise
            // 
            lblAdvise.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAdvise.Location = new Point(15, 295);
            lblAdvise.Name = "lblAdvise";
            lblAdvise.Size = new Size(431, 39);
            lblAdvise.TabIndex = 3;
            lblAdvise.Text = "\"Screen\" based positions will be relative to the top / left corner of your primary monitor.";
            // 
            // checkShowAll
            // 
            checkShowAll.AutoSize = true;
            checkShowAll.FlatStyle = FlatStyle.System;
            checkShowAll.Location = new Point(143, 35);
            checkShowAll.Margin = new Padding(0);
            checkShowAll.Name = "checkShowAll";
            checkShowAll.Size = new Size(122, 20);
            checkShowAll.TabIndex = 2;
            checkShowAll.Text = "Show all overlays";
            checkShowAll.UseVisualStyleBackColor = true;
            checkShowAll.CheckedChanged += checkShowAll_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Default", "Ship", "SRV", "System Map", "Galaxy Map", "FSS", "DSS" });
            comboBox1.Location = new Point(14, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 23);
            comboBox1.TabIndex = 9;
            // 
            // FormAdjustOverlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(458, 378);
            Controls.Add(lblAdvise);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(checkShowAll);
            Controls.Add(groupBox1);
            Controls.Add(comboPlotter);
            Controls.Add(lblChoose);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdjustOverlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adjust Overlays";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVRScale).EndInit();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVRX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVRY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVRZ).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOpacity).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVRYaw).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVRPitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVRRoll).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoose;
        private ComboBox comboPlotter;
        private Button btnCancel;
        private Button btnAccept;
        private CheckBox checkLeft;
        private CheckBox checkCenter;
        private CheckBox checkRight;
        private CheckBox checkTop;
        private CheckBox checkMiddle;
        private CheckBox checkBottom;
        private Label labelOffset;
        private NumericUpDown numY;
        private NumericUpDown numX;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox checkHScreen;
        private CheckBox checkVScreen;
        private Button btnReset;
        private Label lblAdvise;
        private CheckBox checkOpacity;
        private FlowLayoutPanel flowLayoutPanel5;
        private NumericUpDown numOpacity;
        private CheckBox checkShowAll;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label3;
        private NumericUpDown numVRScale;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label1;
        private NumericUpDown numVRX;
        private NumericUpDown numVRY;
        private NumericUpDown numVRZ;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label2;
        private NumericUpDown numVRYaw;
        private NumericUpDown numVRPitch;
        private NumericUpDown numVRRoll;
        private ComboBox comboBox1;
    }
}