namespace MobileControlGuru.AutoTask
{
    partial class TaskEditItem
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
            this.label1 = new AntdUI.Label();
            this.button1 = new AntdUI.Button();
            this.input1 = new AntdUI.Input();
            this.select1 = new AntdUI.Select();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "操作";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "删 除";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(194, 4);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(231, 37);
            this.input1.TabIndex = 3;
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(74, 3);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(114, 37);
            this.select1.TabIndex = 4;
            this.select1.Text = "select1";
            this.select1.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select1_SelectedIndexChanged);
            // 
            // TaskEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.select1);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TaskEditItem";
            this.Size = new System.Drawing.Size(502, 48);
            this.Load += new System.EventHandler(this.TaskEditItem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Input input1;
        private AntdUI.Select select1;
    }
}
