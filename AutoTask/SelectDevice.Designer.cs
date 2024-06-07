namespace MobileControlGuru.AutoTask
{
    partial class SelectDevice
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
            this.select1 = new AntdUI.Select();
            this.button1 = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(12, 12);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(180, 39);
            this.select1.TabIndex = 0;
            this.select1.Text = "select1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.select1);
            this.Name = "SelectDevice";
            this.Text = "SelectDevice";
            this.Load += new System.EventHandler(this.SelectDevice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public AntdUI.Select select1;
        public AntdUI.Button button1;
    }
}