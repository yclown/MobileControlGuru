namespace MobileControlGuru
{
    partial class MoblieControl
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
            this.input1 = new AntdUI.Input();
            this.put = new AntdUI.Button();
            this.wireless_connect = new AntdUI.Button();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.checkbox1 = new AntdUI.Checkbox();
            this.disconnect = new AntdUI.Button();
            this.disput = new AntdUI.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(34, 3);
            this.input1.Name = "input1";
            this.input1.ReadOnly = true;
            this.input1.Size = new System.Drawing.Size(118, 39);
            this.input1.TabIndex = 0;
            // 
            // put
            // 
            this.put.Location = new System.Drawing.Point(158, 3);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(67, 38);
            this.put.TabIndex = 1;
            this.put.Text = "投屏";
            this.put.Click += new System.EventHandler(this.put_Click);
            // 
            // wireless_connect
            // 
            this.wireless_connect.Location = new System.Drawing.Point(231, 3);
            this.wireless_connect.Name = "wireless_connect";
            this.wireless_connect.Size = new System.Drawing.Size(75, 38);
            this.wireless_connect.TabIndex = 2;
            this.wireless_connect.Text = "无线连接";
            this.wireless_connect.Click += new System.EventHandler(this.wireless_connect_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkbox1);
            this.flowLayoutPanel1.Controls.Add(this.input1);
            this.flowLayoutPanel1.Controls.Add(this.put);
            this.flowLayoutPanel1.Controls.Add(this.wireless_connect);
            this.flowLayoutPanel1.Controls.Add(this.disconnect);
            this.flowLayoutPanel1.Controls.Add(this.disput);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // checkbox1
            // 
            this.checkbox1.Location = new System.Drawing.Point(3, 3);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(25, 38);
            this.checkbox1.TabIndex = 6;
            this.checkbox1.Text = " ";
            this.checkbox1.CheckedChanged += new AntdUI.BoolEventHandler(this.checkbox1_CheckedChanged);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(312, 3);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 38);
            this.disconnect.TabIndex = 5;
            this.disconnect.Text = "断开连接";
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // disput
            // 
            this.disput.Location = new System.Drawing.Point(393, 3);
            this.disput.Name = "disput";
            this.disput.Size = new System.Drawing.Size(75, 38);
            this.disput.TabIndex = 3;
            this.disput.Text = "停止投屏";
            this.disput.Click += new System.EventHandler(this.disput_Click);
            // 
            // MoblieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MoblieControl";
            this.Size = new System.Drawing.Size(501, 51);
            this.Load += new System.EventHandler(this.MoblieControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Input input1;
        private AntdUI.Button put;
        private AntdUI.Button wireless_connect;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button disconnect;
        private AntdUI.Button disput;
        private AntdUI.Checkbox checkbox1;
    }
}
