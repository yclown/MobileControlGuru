namespace MobileControlGuru
{
    partial class ScrcpySetting
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
            this.NoAudioSwitch = new AntdUI.Switch();
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.WindowWidthInput = new AntdUI.Input();
            this.WindowHeightInput = new AntdUI.Input();
            this.WindowYInput = new AntdUI.Input();
            this.WindowXInput = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.button1 = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // NoAudioSwitch
            // 
            this.NoAudioSwitch.Location = new System.Drawing.Point(83, 26);
            this.NoAudioSwitch.Name = "NoAudioSwitch";
            this.NoAudioSwitch.Size = new System.Drawing.Size(44, 23);
            this.NoAudioSwitch.TabIndex = 0;
            this.NoAudioSwitch.Text = "音频";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "无音频";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "默认宽度";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(182, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "默认高度";
            // 
            // WindowWidthInput
            // 
            this.WindowWidthInput.Location = new System.Drawing.Point(83, 72);
            this.WindowWidthInput.Name = "WindowWidthInput";
            this.WindowWidthInput.Size = new System.Drawing.Size(75, 32);
            this.WindowWidthInput.TabIndex = 4;
            // 
            // WindowHeightInput
            // 
            this.WindowHeightInput.Location = new System.Drawing.Point(245, 72);
            this.WindowHeightInput.Name = "WindowHeightInput";
            this.WindowHeightInput.Size = new System.Drawing.Size(75, 32);
            this.WindowHeightInput.TabIndex = 5;
            // 
            // WindowYInput
            // 
            this.WindowYInput.Location = new System.Drawing.Point(531, 72);
            this.WindowYInput.Name = "WindowYInput";
            this.WindowYInput.Size = new System.Drawing.Size(75, 32);
            this.WindowYInput.TabIndex = 9;
            // 
            // WindowXInput
            // 
            this.WindowXInput.Location = new System.Drawing.Point(388, 72);
            this.WindowXInput.Name = "WindowXInput";
            this.WindowXInput.Size = new System.Drawing.Size(75, 32);
            this.WindowXInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(487, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "初始Y";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(344, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "初始X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "保存";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScrcpySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WindowYInput);
            this.Controls.Add(this.WindowXInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WindowHeightInput);
            this.Controls.Add(this.WindowWidthInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoAudioSwitch);
            this.Name = "ScrcpySetting";
            this.Text = "投屏参数";
            this.Load += new System.EventHandler(this.ScrcpySetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Switch NoAudioSwitch;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Input WindowWidthInput;
        private AntdUI.Input WindowHeightInput;
        private AntdUI.Input WindowYInput;
        private AntdUI.Input WindowXInput;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Button button1;
    }
}