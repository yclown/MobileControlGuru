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
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.button4 = new AntdUI.Button();
            this.input1 = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.flowLayoutPanel2 = new AntdUI.In.FlowLayoutPanel();
            this.input3 = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.input2 = new AntdUI.Input();
            this.button5 = new AntdUI.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 104);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 459);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(432, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加操作";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(513, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "保存任务";
            this.button2.Type = AntdUI.TTypeMini.Success;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(512, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "清空";
            this.button3.Type = AntdUI.TTypeMini.Error;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "任务名";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(432, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "调试";
            this.button4.Type = AntdUI.TTypeMini.Warn;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(79, 3);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(124, 33);
            this.input1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(209, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "设备ID";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.input1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.input3);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.input2);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(414, 86);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(261, 3);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(139, 33);
            this.input3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Corn表达式";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(79, 42);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(124, 33);
            this.input2.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(209, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Corn帮助";
            // 
            // TaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 576);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Name = "TaskEdit";
            this.Text = "TaskEdit";
            this.Load += new System.EventHandler(this.TaskEdit_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Label label1;
        private AntdUI.Button button4;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel2;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Button button5;
        private AntdUI.Input input3;
    }
}