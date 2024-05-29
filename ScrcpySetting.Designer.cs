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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrcpySetting));
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
            this.KeyboardUhidSwitch = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.turn_screen_off = new AntdUI.Switch();
            this.label8 = new AntdUI.Label();
            this.stay_awake = new AntdUI.Switch();
            this.flowLayoutPanel2 = new AntdUI.In.FlowLayoutPanel();
            this.AlwaysOnTop = new AntdUI.Switch();
            this.label9 = new AntdUI.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoAudioSwitch
            // 
            resources.ApplyResources(this.NoAudioSwitch, "NoAudioSwitch");
            this.NoAudioSwitch.Name = "NoAudioSwitch";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // WindowWidthInput
            // 
            resources.ApplyResources(this.WindowWidthInput, "WindowWidthInput");
            this.WindowWidthInput.Name = "WindowWidthInput";
            // 
            // WindowHeightInput
            // 
            resources.ApplyResources(this.WindowHeightInput, "WindowHeightInput");
            this.WindowHeightInput.Name = "WindowHeightInput";
            // 
            // WindowYInput
            // 
            resources.ApplyResources(this.WindowYInput, "WindowYInput");
            this.WindowYInput.Name = "WindowYInput";
            // 
            // WindowXInput
            // 
            resources.ApplyResources(this.WindowXInput, "WindowXInput");
            this.WindowXInput.Name = "WindowXInput";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyboardUhidSwitch
            // 
            resources.ApplyResources(this.KeyboardUhidSwitch, "KeyboardUhidSwitch");
            this.KeyboardUhidSwitch.Name = "KeyboardUhidSwitch";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // turn_screen_off
            // 
            resources.ApplyResources(this.turn_screen_off, "turn_screen_off");
            this.turn_screen_off.Name = "turn_screen_off";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // stay_awake
            // 
            resources.ApplyResources(this.stay_awake, "stay_awake");
            this.stay_awake.Name = "stay_awake";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.WindowWidthInput);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.WindowHeightInput);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.WindowXInput);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.WindowYInput);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // AlwaysOnTop
            // 
            resources.ApplyResources(this.AlwaysOnTop, "AlwaysOnTop");
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // ScrcpySetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AlwaysOnTop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoAudioSwitch);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KeyboardUhidSwitch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stay_awake);
            this.Controls.Add(this.turn_screen_off);
            this.Controls.Add(this.label8);
            this.Name = "ScrcpySetting";
            this.Load += new System.EventHandler(this.ScrcpySetting_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
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
        private AntdUI.Switch KeyboardUhidSwitch;
        private AntdUI.Label label6;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel2;
        private AntdUI.Label label7;
        private AntdUI.Switch turn_screen_off;
        private AntdUI.Label label8;
        private AntdUI.Switch stay_awake;
        private AntdUI.Switch AlwaysOnTop;
        private AntdUI.Label label9;
    }
}