﻿namespace KeppySynthConfigurator
{
    partial class AdvancedAudioSettings
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
            this.AOS = new System.Windows.Forms.GroupBox();
            this.AudioBitDepth = new System.Windows.Forms.ComboBox();
            this.AudioBitDepthLabel = new System.Windows.Forms.Label();
            this.MonophonicFunc = new System.Windows.Forms.CheckBox();
            this.FadeoutDisable = new System.Windows.Forms.CheckBox();
            this.ABS = new System.Windows.Forms.GroupBox();
            this.NoSleep = new System.Windows.Forms.CheckBox();
            this.SlowDownPlayback = new System.Windows.Forms.CheckBox();
            this.OldBuff = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangePitchShifting = new System.Windows.Forms.Button();
            this.ChangeDefaultOutput = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CAE = new System.Windows.Forms.Label();
            this.AOS.SuspendLayout();
            this.ABS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AOS
            // 
            this.AOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AOS.Controls.Add(this.AudioBitDepth);
            this.AOS.Controls.Add(this.AudioBitDepthLabel);
            this.AOS.Controls.Add(this.MonophonicFunc);
            this.AOS.Controls.Add(this.FadeoutDisable);
            this.AOS.Location = new System.Drawing.Point(12, 12);
            this.AOS.Name = "AOS";
            this.AOS.Size = new System.Drawing.Size(345, 92);
            this.AOS.TabIndex = 0;
            this.AOS.TabStop = false;
            this.AOS.Text = "Audio output settings";
            // 
            // AudioBitDepth
            // 
            this.AudioBitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioBitDepth.FormattingEnabled = true;
            this.AudioBitDepth.Items.AddRange(new object[] {
            "32-bit float",
            "16-bit integer",
            "8-bit integer"});
            this.AudioBitDepth.Location = new System.Drawing.Point(89, 20);
            this.AudioBitDepth.Name = "AudioBitDepth";
            this.AudioBitDepth.Size = new System.Drawing.Size(85, 21);
            this.AudioBitDepth.TabIndex = 3;
            this.AudioBitDepth.SelectedIndexChanged += new System.EventHandler(this.AudioBitDepth_SelectedIndexChanged);
            // 
            // AudioBitDepthLabel
            // 
            this.AudioBitDepthLabel.AutoSize = true;
            this.AudioBitDepthLabel.Location = new System.Drawing.Point(6, 23);
            this.AudioBitDepthLabel.Name = "AudioBitDepthLabel";
            this.AudioBitDepthLabel.Size = new System.Drawing.Size(81, 13);
            this.AudioBitDepthLabel.TabIndex = 2;
            this.AudioBitDepthLabel.Text = "Audio bit depth:";
            // 
            // MonophonicFunc
            // 
            this.MonophonicFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MonophonicFunc.AutoSize = true;
            this.MonophonicFunc.Location = new System.Drawing.Point(6, 48);
            this.MonophonicFunc.Name = "MonophonicFunc";
            this.MonophonicFunc.Size = new System.Drawing.Size(153, 17);
            this.MonophonicFunc.TabIndex = 1;
            this.MonophonicFunc.Text = "Use monophonic rendering";
            this.MonophonicFunc.UseVisualStyleBackColor = true;
            this.MonophonicFunc.CheckedChanged += new System.EventHandler(this.MonophonicFunc_CheckedChanged);
            // 
            // FadeoutDisable
            // 
            this.FadeoutDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FadeoutDisable.AutoSize = true;
            this.FadeoutDisable.Location = new System.Drawing.Point(6, 67);
            this.FadeoutDisable.Name = "FadeoutDisable";
            this.FadeoutDisable.Size = new System.Drawing.Size(217, 17);
            this.FadeoutDisable.TabIndex = 0;
            this.FadeoutDisable.Text = "Disable fade-out when killing an old note";
            this.FadeoutDisable.UseVisualStyleBackColor = true;
            this.FadeoutDisable.CheckedChanged += new System.EventHandler(this.FadeoutDisable_CheckedChanged);
            // 
            // ABS
            // 
            this.ABS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ABS.Controls.Add(this.NoSleep);
            this.ABS.Controls.Add(this.SlowDownPlayback);
            this.ABS.Controls.Add(this.OldBuff);
            this.ABS.Location = new System.Drawing.Point(12, 110);
            this.ABS.Name = "ABS";
            this.ABS.Size = new System.Drawing.Size(345, 80);
            this.ABS.TabIndex = 4;
            this.ABS.TabStop = false;
            this.ABS.Text = "Audio buffer settings";
            // 
            // NoSleep
            // 
            this.NoSleep.AutoSize = true;
            this.NoSleep.Location = new System.Drawing.Point(6, 57);
            this.NoSleep.Name = "NoSleep";
            this.NoSleep.Size = new System.Drawing.Size(211, 17);
            this.NoSleep.TabIndex = 6;
            this.NoSleep.Text = "Disable sleep states (Unsupported, DS)";
            this.NoSleep.UseVisualStyleBackColor = true;
            this.NoSleep.CheckedChanged += new System.EventHandler(this.NoSleep_CheckedChanged);
            // 
            // SlowDownPlayback
            // 
            this.SlowDownPlayback.AutoSize = true;
            this.SlowDownPlayback.Location = new System.Drawing.Point(6, 19);
            this.SlowDownPlayback.Name = "SlowDownPlayback";
            this.SlowDownPlayback.Size = new System.Drawing.Size(244, 17);
            this.SlowDownPlayback.TabIndex = 5;
            this.SlowDownPlayback.Text = "Slow down playback instead of skipping notes";
            this.SlowDownPlayback.UseVisualStyleBackColor = true;
            this.SlowDownPlayback.CheckedChanged += new System.EventHandler(this.SlowDownPlayback_CheckedChanged);
            // 
            // OldBuff
            // 
            this.OldBuff.AutoSize = true;
            this.OldBuff.Location = new System.Drawing.Point(6, 38);
            this.OldBuff.Name = "OldBuff";
            this.OldBuff.Size = new System.Drawing.Size(276, 17);
            this.OldBuff.TabIndex = 4;
            this.OldBuff.Text = "Enable the old buffer system (Unsupported, XA && DS)";
            this.OldBuff.UseVisualStyleBackColor = true;
            this.OldBuff.CheckedChanged += new System.EventHandler(this.OldBuff_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChangePitchShifting);
            this.groupBox1.Controls.Add(this.ChangeDefaultOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other settings";
            // 
            // ChangePitchShifting
            // 
            this.ChangePitchShifting.Location = new System.Drawing.Point(177, 17);
            this.ChangePitchShifting.Name = "ChangePitchShifting";
            this.ChangePitchShifting.Size = new System.Drawing.Size(162, 23);
            this.ChangePitchShifting.TabIndex = 1;
            this.ChangePitchShifting.Text = "Change pitch shifting";
            this.ChangePitchShifting.UseVisualStyleBackColor = true;
            this.ChangePitchShifting.Click += new System.EventHandler(this.ChangePitchShifting_Click);
            // 
            // ChangeDefaultOutput
            // 
            this.ChangeDefaultOutput.Location = new System.Drawing.Point(6, 17);
            this.ChangeDefaultOutput.Name = "ChangeDefaultOutput";
            this.ChangeDefaultOutput.Size = new System.Drawing.Size(160, 23);
            this.ChangeDefaultOutput.TabIndex = 0;
            this.ChangeDefaultOutput.Text = "Change default audio output";
            this.ChangeDefaultOutput.UseVisualStyleBackColor = true;
            this.ChangeDefaultOutput.Click += new System.EventHandler(this.ChangeDefaultOutput_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.Location = new System.Drawing.Point(282, 254);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CAE
            // 
            this.CAE.AutoSize = true;
            this.CAE.Enabled = false;
            this.CAE.Location = new System.Drawing.Point(15, 259);
            this.CAE.Name = "CAE";
            this.CAE.Size = new System.Drawing.Size(125, 13);
            this.CAE.TabIndex = 9;
            this.CAE.Text = "Current audio engine: {0}";
            // 
            // AdvancedAudioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 289);
            this.Controls.Add(this.CAE);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ABS);
            this.Controls.Add(this.AOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedAudioSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced audio settings";
            this.Load += new System.EventHandler(this.AdvancedAudioSettings_Load);
            this.AOS.ResumeLayout(false);
            this.AOS.PerformLayout();
            this.ABS.ResumeLayout(false);
            this.ABS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AOS;
        private System.Windows.Forms.Label AudioBitDepthLabel;
        private System.Windows.Forms.CheckBox MonophonicFunc;
        private System.Windows.Forms.CheckBox FadeoutDisable;
        private System.Windows.Forms.ComboBox AudioBitDepth;
        private System.Windows.Forms.GroupBox ABS;
        private System.Windows.Forms.CheckBox NoSleep;
        private System.Windows.Forms.CheckBox SlowDownPlayback;
        private System.Windows.Forms.CheckBox OldBuff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangePitchShifting;
        private System.Windows.Forms.Button ChangeDefaultOutput;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label CAE;
    }
}