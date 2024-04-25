namespace MobileControlGuru
{
    partial class IPConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPConnect));
            this.ip_input = new AntdUI.Input();
            this.label1 = new AntdUI.Label();
            this.panel1 = new AntdUI.Panel();
            this.connect_btn = new AntdUI.Button();
            this.port_input = new AntdUI.InputNumber();
            this.label2 = new AntdUI.Label();
            this.button1 = new AntdUI.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_input
            // 
            resources.ApplyResources(this.ip_input, "ip_input");
            this.ip_input.Name = "ip_input";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.connect_btn);
            this.panel1.Controls.Add(this.port_input);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ip_input);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // connect_btn
            // 
            resources.ApplyResources(this.connect_btn, "connect_btn");
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Type = AntdUI.TTypeMini.Primary;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // port_input
            // 
            resources.ApplyResources(this.port_input, "port_input");
            this.port_input.Name = "port_input";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Type = AntdUI.TTypeMini.Success;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPConnect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "IPConnect";
            this.Load += new System.EventHandler(this.IPConnect_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Input ip_input;
        private AntdUI.Label label1;
        private AntdUI.Panel panel1;
        private AntdUI.Label label2;
        private AntdUI.Button connect_btn;
        private AntdUI.InputNumber port_input;
        private AntdUI.Button button1;
    }
}