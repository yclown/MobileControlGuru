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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoblieControl));
            this.input1 = new AntdUI.Input();
            this.put = new AntdUI.Button();
            this.wireless_connect = new AntdUI.Button();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.checkbox1 = new AntdUI.Checkbox();
            this.disput = new AntdUI.Button();
            this.disconnect = new AntdUI.Button();
            this.show = new AntdUI.Button();
            this.ontop = new AntdUI.Button();
            this.runtask = new AntdUI.Button();
            this.log_btn = new AntdUI.Button();
            this.end_task = new AntdUI.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input1
            // 
            resources.ApplyResources(this.input1, "input1");
            this.input1.Name = "input1";
            this.input1.ReadOnly = true;
            // 
            // put
            // 
            resources.ApplyResources(this.put, "put");
            this.put.Name = "put";
            this.put.Type = AntdUI.TTypeMini.Success;
            this.put.Click += new System.EventHandler(this.put_Click);
            // 
            // wireless_connect
            // 
            resources.ApplyResources(this.wireless_connect, "wireless_connect");
            this.wireless_connect.Name = "wireless_connect";
            this.wireless_connect.Click += new System.EventHandler(this.wireless_connect_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkbox1);
            this.flowLayoutPanel1.Controls.Add(this.input1);
            this.flowLayoutPanel1.Controls.Add(this.put);
            this.flowLayoutPanel1.Controls.Add(this.disput);
            this.flowLayoutPanel1.Controls.Add(this.wireless_connect);
            this.flowLayoutPanel1.Controls.Add(this.disconnect);
            this.flowLayoutPanel1.Controls.Add(this.show);
            this.flowLayoutPanel1.Controls.Add(this.ontop);
            this.flowLayoutPanel1.Controls.Add(this.runtask);
            this.flowLayoutPanel1.Controls.Add(this.log_btn);
            this.flowLayoutPanel1.Controls.Add(this.end_task);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // checkbox1
            // 
            resources.ApplyResources(this.checkbox1, "checkbox1");
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.CheckedChanged += new AntdUI.BoolEventHandler(this.checkbox1_CheckedChanged);
            // 
            // disput
            // 
            resources.ApplyResources(this.disput, "disput");
            this.disput.Name = "disput";
            this.disput.Type = AntdUI.TTypeMini.Warn;
            this.disput.Click += new System.EventHandler(this.disput_Click);
            // 
            // disconnect
            // 
            resources.ApplyResources(this.disconnect, "disconnect");
            this.disconnect.Name = "disconnect";
            this.disconnect.Type = AntdUI.TTypeMini.Error;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // show
            // 
            this.show.BackgroundImage = global::MobileControlGuru.Properties.Resources.see;
            this.show.Ghost = true;
            this.show.ImageSvg = "";
            resources.ApplyResources(this.show, "show");
            this.show.Name = "show";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // ontop
            // 
            this.ontop.BackgroundImage = global::MobileControlGuru.Properties.Resources.ontop;
            this.ontop.Ghost = true;
            this.ontop.ImageSvg = "";
            resources.ApplyResources(this.ontop, "ontop");
            this.ontop.Name = "ontop";
            this.ontop.Click += new System.EventHandler(this.ontop_Click);
            // 
            // runtask
            // 
            resources.ApplyResources(this.runtask, "runtask");
            this.runtask.Name = "runtask";
            this.runtask.Type = AntdUI.TTypeMini.Primary;
            // 
            // log_btn
            // 
            resources.ApplyResources(this.log_btn, "log_btn");
            this.log_btn.Name = "log_btn";
            this.log_btn.Type = AntdUI.TTypeMini.Primary;
            // 
            // end_task
            // 
            resources.ApplyResources(this.end_task, "end_task");
            this.end_task.Name = "end_task";
            this.end_task.Type = AntdUI.TTypeMini.Warn;
            // 
            // MoblieControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MoblieControl";
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
        private AntdUI.Button ontop;
        private AntdUI.Button show;
        private AntdUI.Button runtask;
        private AntdUI.Button log_btn;
        private AntdUI.Button end_task;
    }
}
