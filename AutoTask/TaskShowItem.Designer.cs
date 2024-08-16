namespace MobileControlGuru.AutoTask
{
    partial class TaskShowItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.edit = new AntdUI.Button();
            this.del = new AntdUI.Button();
            this.run = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.run_able = new AntdUI.Button();
            this.button4 = new AntdUI.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(165, 3);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 36);
            this.edit.TabIndex = 0;
            this.edit.Text = "编 辑";
            this.edit.Type = AntdUI.TTypeMini.Success;
            this.edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(246, 3);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 36);
            this.del.TabIndex = 1;
            this.del.Text = "删 除";
            this.del.Type = AntdUI.TTypeMini.Error;
            this.del.Click += new System.EventHandler(this.button2_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(84, 3);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 36);
            this.run.TabIndex = 2;
            this.run.Text = "运行";
            this.run.Type = AntdUI.TTypeMini.Primary;
            this.run.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "";
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(435, 7);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(92, 35);
            this.inputNumber1.TabIndex = 4;
            this.inputNumber1.Text = "1";
            this.inputNumber1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber1.Visible = false;
            this.inputNumber1.ValueChanged += new AntdUI.DecimalEventHandler(this.inputNumber1_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.run_able);
            this.flowLayoutPanel1.Controls.Add(this.run);
            this.flowLayoutPanel1.Controls.Add(this.edit);
            this.flowLayoutPanel1.Controls.Add(this.del);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 94);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // run_able
            // 
            this.run_able.Location = new System.Drawing.Point(3, 3);
            this.run_able.Name = "run_able";
            this.run_able.Size = new System.Drawing.Size(75, 36);
            this.run_able.TabIndex = 4;
            this.run_able.Text = "禁用中";
            this.run_able.Type = AntdUI.TTypeMini.Warn;
            this.run_able.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "日志";
            this.button4.Type = AntdUI.TTypeMini.Primary;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TaskShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.label1);
            this.Name = "TaskShowItem";
            this.Size = new System.Drawing.Size(536, 48);
            this.Load += new System.EventHandler(this.TaskShowItem_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Button edit;
        private AntdUI.Button del;
        private AntdUI.Button run;
        private AntdUI.Label label1;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button button4;
        private AntdUI.Button run_able;
    }
}
