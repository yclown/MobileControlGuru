using static AntdUI.Modal;
using System.Drawing;

namespace MobileControlGuru
{
    partial class ScrcpyConrtrolPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrcpyConrtrolPanel));
            this.home_btn = new AntdUI.Button();
            this.back_btn = new AntdUI.Button();
            this.screencap_btn = new AntdUI.Button();
            this.exit_btn = new AntdUI.Button();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
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
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
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
            this.screencap_btn.Click += new System.EventHandler(this.screencap_btn_Click);
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
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(83, 279);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ScrcpyConrtrolPanel
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(136, 319);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScrcpyConrtrolPanel";
            this.Text = "ScrcpyConrtrolPanel";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Button home_btn;
        private AntdUI.Button screencap_btn;
        private AntdUI.Button exit_btn;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button back_btn;
    }
}