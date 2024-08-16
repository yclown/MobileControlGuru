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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrcpyForm));
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.home_btn = new AntdUI.Button();
            this.back_btn = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.opca = new AntdUI.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.home_btn);
            this.flowLayoutPanel1.Controls.Add(this.back_btn);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.opca);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(450, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(53, 567);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.home_btn.ImageSvg = resources.GetString("home_btn.ImageSvg");
            this.home_btn.Location = new System.Drawing.Point(3, 3);
            this.home_btn.Name = "home_btn";
            this.home_btn.Shape = AntdUI.TShape.Circle;
            this.home_btn.Size = new System.Drawing.Size(44, 44);
            this.home_btn.TabIndex = 0;
            this.home_btn.Type = AntdUI.TTypeMini.Info;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.back_btn.ImageSvg = resources.GetString("back_btn.ImageSvg");
            this.back_btn.Location = new System.Drawing.Point(3, 53);
            this.back_btn.Name = "back_btn";
            this.back_btn.Shape = AntdUI.TShape.Circle;
            this.back_btn.Size = new System.Drawing.Size(44, 41);
            this.back_btn.TabIndex = 2;
            this.back_btn.Type = AntdUI.TTypeMini.Info;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.button2.ImageSvg = resources.GetString("button2.ImageSvg");
            this.button2.Location = new System.Drawing.Point(3, 100);
            this.button2.Name = "button2";
            this.button2.Shape = AntdUI.TShape.Circle;
            this.button2.Size = new System.Drawing.Size(44, 41);
            this.button2.TabIndex = 6;
            this.button2.Type = AntdUI.TTypeMini.Primary;
            // 
            // opca
            // 
            this.opca.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.opca.ImageSvg = resources.GetString("opca.ImageSvg");
            this.opca.Location = new System.Drawing.Point(3, 147);
            this.opca.Name = "opca";
            this.opca.Shape = AntdUI.TShape.Circle;
            this.opca.Size = new System.Drawing.Size(44, 41);
            this.opca.TabIndex = 5;
            this.opca.Type = AntdUI.TTypeMini.Primary;
            this.opca.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 567);
            this.panel1.TabIndex = 7;
            // 
            // ScrcpyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScrcpyForm";
            this.Text = "x";
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
        private System.Windows.Forms.Panel panel1;
        private AntdUI.Button opca;
        private AntdUI.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private AntdUI.TooltipComponent tooltipComponent1;
    }
}