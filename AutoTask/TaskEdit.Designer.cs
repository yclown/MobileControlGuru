namespace MobileControlGuru.AutoTask
{
    partial class TaskEdit
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
            this.taskEditItem1 = new MobileControlGuru.AutoTask.TaskEditItem();
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.button4 = new AntdUI.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.taskEditItem1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 403);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // taskEditItem1
            // 
            this.taskEditItem1.deleteEevnt = null;
            this.taskEditItem1.Location = new System.Drawing.Point(3, 3);
            this.taskEditItem1.Name = "taskEditItem1";
            this.taskEditItem1.Size = new System.Drawing.Size(396, 48);
            this.taskEditItem1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(432, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(432, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "保存";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(432, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "清空";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "名称：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "调试";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 457);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TaskEdit";
            this.Text = "TaskEdit";
            this.Load += new System.EventHandler(this.TaskEdit_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Label label1;
        private TaskEditItem taskEditItem1;
        private AntdUI.Label label2;
        private AntdUI.Button button4;
    }
}