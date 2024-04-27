namespace MobileControlGuru
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.table1 = new AntdUI.Table();
            this.getDevices_btn = new AntdUI.Button();
            this.ipconnect_btn = new AntdUI.Button();
            this.dropdown1 = new AntdUI.Dropdown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mini_menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.main_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_tmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_select = new System.Windows.Forms.ComboBox();
            this.button1 = new AntdUI.Button();
            this.divider1 = new AntdUI.Divider();
            this.button2 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.api_run = new AntdUI.Button();
            this.api_close = new AntdUI.Button();
            this.button4 = new AntdUI.Button();
            this.x_input = new AntdUI.InputNumber();
            this.button5 = new AntdUI.Button();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.y_input = new AntdUI.InputNumber();
            this.divider2 = new AntdUI.Divider();
            this.mini_menustrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table1
            // 
            resources.ApplyResources(this.table1, "table1");
            this.table1.Bordered = true;
            this.table1.EditMode = AntdUI.TEditMode.DoubleClick;
            this.table1.Name = "table1";
            this.table1.CellButtonClick += new AntdUI.Table.ClickButtonEventHandler(this.table1_CellButtonClick);
            // 
            // getDevices_btn
            // 
            resources.ApplyResources(this.getDevices_btn, "getDevices_btn");
            this.getDevices_btn.Name = "getDevices_btn";
            this.getDevices_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipconnect_btn
            // 
            this.ipconnect_btn.BorderWidth = 1F;
            resources.ApplyResources(this.ipconnect_btn, "ipconnect_btn");
            this.ipconnect_btn.Name = "ipconnect_btn";
            this.ipconnect_btn.Click += new System.EventHandler(this.ipconnect_btn_Click);
            // 
            // dropdown1
            // 
            resources.ApplyResources(this.dropdown1, "dropdown1");
            this.dropdown1.ImageSize = new System.Drawing.Size(32, 32);
            this.dropdown1.ImageSvg = resources.GetString("dropdown1.ImageSvg");
            this.dropdown1.Items.AddRange(new object[] {
            "系统设置"});
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.dropdown1_SelectedValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.mini_menustrip;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // mini_menustrip
            // 
            this.mini_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main_tsmi,
            this.setting_tmsi,
            this.exit_tsmi});
            this.mini_menustrip.Name = "mini_menustrip";
            resources.ApplyResources(this.mini_menustrip, "mini_menustrip");
            // 
            // main_tsmi
            // 
            this.main_tsmi.Name = "main_tsmi";
            resources.ApplyResources(this.main_tsmi, "main_tsmi");
            this.main_tsmi.Click += new System.EventHandler(this.main_tsmi_Click);
            // 
            // setting_tmsi
            // 
            this.setting_tmsi.Name = "setting_tmsi";
            resources.ApplyResources(this.setting_tmsi, "setting_tmsi");
            this.setting_tmsi.Click += new System.EventHandler(this.setting_tmsi_Click);
            // 
            // exit_tsmi
            // 
            this.exit_tsmi.Name = "exit_tsmi";
            resources.ApplyResources(this.exit_tsmi, "exit_tsmi");
            this.exit_tsmi.Click += new System.EventHandler(this.exit_tsmi_Click);
            // 
            // lang_select
            // 
            this.lang_select.FormattingEnabled = true;
            this.lang_select.Items.AddRange(new object[] {
            resources.GetString("lang_select.Items"),
            resources.GetString("lang_select.Items1")});
            resources.ApplyResources(this.lang_select, "lang_select");
            this.lang_select.Name = "lang_select";
            this.lang_select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // divider1
            // 
            resources.ApplyResources(this.divider1, "divider1");
            this.divider1.Name = "divider1";
            this.divider1.Vertical = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // api_run
            // 
            resources.ApplyResources(this.api_run, "api_run");
            this.api_run.Name = "api_run";
            this.api_run.Click += new System.EventHandler(this.api_run_Click);
            // 
            // api_close
            // 
            resources.ApplyResources(this.api_close, "api_close");
            this.api_close.Name = "api_close";
            this.api_close.Click += new System.EventHandler(this.api_close_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // x_input
            // 
            resources.ApplyResources(this.x_input, "x_input");
            this.x_input.Name = "x_input";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.x_input);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.y_input);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // y_input
            // 
            resources.ApplyResources(this.y_input, "y_input");
            this.y_input.Name = "y_input";
            // 
            // divider2
            // 
            resources.ApplyResources(this.divider2, "divider2");
            this.divider2.Name = "divider2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.divider2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.api_close);
            this.Controls.Add(this.api_run);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lang_select);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.ipconnect_btn);
            this.Controls.Add(this.getDevices_btn);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mian_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mian_FormClosed);
            this.Load += new System.EventHandler(this.Mian_Load);
            this.mini_menustrip.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Table table1;
        private AntdUI.Button getDevices_btn;
        private AntdUI.Button ipconnect_btn;
        private AntdUI.Dropdown dropdown1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip mini_menustrip;
        private System.Windows.Forms.ToolStripMenuItem setting_tmsi;
        private System.Windows.Forms.ToolStripMenuItem exit_tsmi;
        private System.Windows.Forms.ToolStripMenuItem main_tsmi;
        private System.Windows.Forms.ComboBox lang_select;
        private AntdUI.Button button1;
        private AntdUI.Divider divider1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Button api_run;
        private AntdUI.Button api_close;
        private AntdUI.Button button4;
        private AntdUI.InputNumber x_input;
        private AntdUI.Button button5;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.InputNumber y_input;
        private AntdUI.Divider divider2;
    }
}

