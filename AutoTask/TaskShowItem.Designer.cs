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
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "编 辑";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "删 除";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "运行";
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
            this.inputNumber1.Location = new System.Drawing.Point(345, 4);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(92, 35);
            this.inputNumber1.TabIndex = 4;
            this.inputNumber1.Text = "0";
            // 
            // TaskShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TaskShowItem";
            this.Size = new System.Drawing.Size(440, 43);
            this.Load += new System.EventHandler(this.TaskShowItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Label label1;
        private AntdUI.InputNumber inputNumber1;
    }
}
