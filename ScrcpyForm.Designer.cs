namespace MobileControlGuru
{
    partial class ScrcpyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrcpyForm));
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.home_btn = new AntdUI.Button();
            this.back_btn = new AntdUI.Button();
            this.screencap_btn = new AntdUI.Button();
            this.exit_btn = new AntdUI.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.home_btn);
            this.flowLayoutPanel1.Controls.Add(this.back_btn);
            this.flowLayoutPanel1.Controls.Add(this.screencap_btn);
            this.flowLayoutPanel1.Controls.Add(this.exit_btn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(897, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(76, 551);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.home_btn.ImageSvg = resources.GetString("home_btn.ImageSvg");
            this.home_btn.Location = new System.Drawing.Point(3, 3);
            this.home_btn.Name = "home_btn";
            this.home_btn.Shape = AntdUI.TShape.Circle;
            this.home_btn.Size = new System.Drawing.Size(70, 61);
            this.home_btn.TabIndex = 0;
            this.home_btn.Type = AntdUI.TTypeMini.Info;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.back_btn.ImageSvg = resources.GetString("back_btn.ImageSvg");
            this.back_btn.Location = new System.Drawing.Point(3, 70);
            this.back_btn.Name = "back_btn";
            this.back_btn.Shape = AntdUI.TShape.Circle;
            this.back_btn.Size = new System.Drawing.Size(70, 61);
            this.back_btn.TabIndex = 2;
            this.back_btn.Type = AntdUI.TTypeMini.Info;
            // 
            // screencap_btn
            // 
            this.screencap_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.screencap_btn.ImageSvg = resources.GetString("screencap_btn.ImageSvg");
            this.screencap_btn.Location = new System.Drawing.Point(3, 137);
            this.screencap_btn.Name = "screencap_btn";
            this.screencap_btn.Shape = AntdUI.TShape.Circle;
            this.screencap_btn.Size = new System.Drawing.Size(70, 61);
            this.screencap_btn.TabIndex = 3;
            this.screencap_btn.Type = AntdUI.TTypeMini.Primary;
            this.screencap_btn.Visible = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.exit_btn.ImageSvg = resources.GetString("exit_btn.ImageSvg");
            this.exit_btn.Location = new System.Drawing.Point(3, 204);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Shape = AntdUI.TShape.Circle;
            this.exit_btn.Size = new System.Drawing.Size(70, 61);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Type = AntdUI.TTypeMini.Primary;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 539);
            this.panel1.TabIndex = 7;
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(753, 15);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(116, 38);
            this.inputNumber1.TabIndex = 8;
            this.inputNumber1.Text = "inputNumber1";
            this.inputNumber1.ValueChanged += new AntdUI.DecimalEventHandler(this.inputNumber1_ValueChanged);
            // 
            // ScrcpyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 555);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScrcpyForm";
            this.Text = "ScrcpyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrcpyForm_FormClosing);
            this.Load += new System.EventHandler(this.ScrcpyForm_Load);
            this.Resize += new System.EventHandler(this.ScrcpyForm_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button home_btn;
        private AntdUI.Button back_btn;
        private AntdUI.Button screencap_btn;
        private AntdUI.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private AntdUI.InputNumber inputNumber1;
    }
}