namespace MobileControlGuru
{
    partial class IPPair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPPair));
            this.button1 = new AntdUI.Button();
            this.port_input = new AntdUI.InputNumber();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.ip_input = new AntdUI.Input();
            this.code_input = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Type = AntdUI.TTypeMini.Success;
            this.button1.Click += new System.EventHandler(this.connect_btn_Click);
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ip_input
            // 
            resources.ApplyResources(this.ip_input, "ip_input");
            this.ip_input.Name = "ip_input";
            // 
            // code_input
            // 
            resources.ApplyResources(this.code_input, "code_input");
            this.code_input.Name = "code_input";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // IPPair
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.code_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.port_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_input);
            this.Name = "IPPair";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.InputNumber port_input;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Input ip_input;
        private AntdUI.InputNumber code_input;
        private AntdUI.Label label3;
    }
}