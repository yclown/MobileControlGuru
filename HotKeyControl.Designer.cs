namespace MobileControlGuru
{
    partial class HotKeyControl
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
            this.EventName = new AntdUI.Label();
            this.Key = new AntdUI.Button();
            this.ModifyKey = new AntdUI.Dropdown();
            this.SuspendLayout();
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(0, 9);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(102, 23);
            this.EventName.TabIndex = 0;
            this.EventName.Text = "label1";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(203, 4);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(79, 35);
            this.Key.TabIndex = 2;
            this.Key.Text = "button2";
            this.Key.Click += new System.EventHandler(this.button2_Click);
            this.Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_KeyDown);
            // 
            // ModifyKey
            // 
            this.ModifyKey.Items.AddRange(new object[] {
            "Alt",
            "Ctrl",
            "Ctrl+Alt"});
            this.ModifyKey.Location = new System.Drawing.Point(108, 3);
            this.ModifyKey.Name = "ModifyKey";
            this.ModifyKey.Size = new System.Drawing.Size(89, 36);
            this.ModifyKey.TabIndex = 3;
            this.ModifyKey.Text = "dropdown1";
            this.ModifyKey.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.ModifyKey_SelectedValueChanged);
            // 
            // HotKeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifyKey);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.EventName);
            this.Name = "HotKeyControl";
            this.Size = new System.Drawing.Size(297, 44);
            this.Load += new System.EventHandler(this.HotKeyControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label EventName;
        private AntdUI.Button Key;
        private AntdUI.Dropdown ModifyKey;
    }
}
