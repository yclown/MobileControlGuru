namespace MobileControlGuru.AutoTask
{
    partial class TaskList
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
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.start_quatrz = new AntdUI.Button();
            this.shutdown = new AntdUI.Button();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(623, 433);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加任务";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(560, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "刷新";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // start_quatrz
            // 
            this.start_quatrz.Location = new System.Drawing.Point(165, 3);
            this.start_quatrz.Name = "start_quatrz";
            this.start_quatrz.Size = new System.Drawing.Size(75, 36);
            this.start_quatrz.TabIndex = 3;
            this.start_quatrz.Text = "开启任务";
            this.start_quatrz.Type = AntdUI.TTypeMini.Success;
            this.start_quatrz.Click += new System.EventHandler(this.button3_Click);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(84, 3);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(75, 36);
            this.shutdown.TabIndex = 4;
            this.shutdown.Text = "关闭任务";
            this.shutdown.Type = AntdUI.TTypeMini.Error;
            this.shutdown.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.start_quatrz);
            this.flowPanel1.Controls.Add(this.shutdown);
            this.flowPanel1.Controls.Add(this.button1);
            this.flowPanel1.Location = new System.Drawing.Point(12, 4);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(260, 42);
            this.flowPanel1.TabIndex = 5;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 497);
            this.Controls.Add(this.flowPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TaskList";
            this.Text = "TaskList";
            this.Load += new System.EventHandler(this.TaskList_Load);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button start_quatrz;
        private AntdUI.Button shutdown;
        private AntdUI.FlowPanel flowPanel1;
    }
}