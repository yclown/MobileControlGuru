﻿namespace MobileControlGuru
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mini_menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.main_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_tmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.swipe_up_btn = new AntdUI.Button();
            this.swipe_down_btn = new AntdUI.Button();
            this.x_input = new AntdUI.InputNumber();
            this.divider4 = new AntdUI.Divider();
            this.label1 = new AntdUI.Label();
            this.play_keycode_btn = new AntdUI.Button();
            this.y_input = new AntdUI.InputNumber();
            this.prv_keycode_btn = new AntdUI.Button();
            this.tap_btn = new AntdUI.Button();
            this.divider3 = new AntdUI.Divider();
            this.next_keycode_btn = new AntdUI.Button();
            this.lock_keycode_btn = new AntdUI.Button();
            this.vadd_keycode_btn = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.bdiv_keycode_btn = new AntdUI.Button();
            this.keycode_input = new AntdUI.Input();
            this.divider2 = new AntdUI.Divider();
            this.button4 = new AntdUI.Button();
            this.api_close = new AntdUI.Button();
            this.api_run = new AntdUI.Button();
            this.lang_select = new System.Windows.Forms.ComboBox();
            this.table1 = new AntdUI.Table();
            this.getDevices_btn = new AntdUI.Button();
            this.ipconnect_btn = new AntdUI.Button();
            this.dropdown1 = new AntdUI.Dropdown();
            this.button5 = new AntdUI.Button();
            this.button6 = new AntdUI.Button();
            this.divider5 = new AntdUI.Divider();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel2 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel3 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel4 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel5 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel6 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel8 = new AntdUI.In.FlowLayoutPanel();
            this.flowLayoutPanel7 = new AntdUI.In.FlowLayoutPanel();
            this.mini_menustrip.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // swipe_up_btn
            // 
            resources.ApplyResources(this.swipe_up_btn, "swipe_up_btn");
            this.swipe_up_btn.Name = "swipe_up_btn";
            this.swipe_up_btn.Tag = "up";
            this.swipe_up_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // swipe_down_btn
            // 
            resources.ApplyResources(this.swipe_down_btn, "swipe_down_btn");
            this.swipe_down_btn.Name = "swipe_down_btn";
            this.swipe_down_btn.Tag = "down";
            this.swipe_down_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // x_input
            // 
            resources.ApplyResources(this.x_input, "x_input");
            this.x_input.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.x_input.Name = "x_input";
            // 
            // divider4
            // 
            resources.ApplyResources(this.divider4, "divider4");
            this.divider4.Name = "divider4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // play_keycode_btn
            // 
            resources.ApplyResources(this.play_keycode_btn, "play_keycode_btn");
            this.play_keycode_btn.Name = "play_keycode_btn";
            this.play_keycode_btn.Tag = "KEYCODE_MEDIA_PLAY_PAUSE";
            this.play_keycode_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // y_input
            // 
            resources.ApplyResources(this.y_input, "y_input");
            this.y_input.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.y_input.Name = "y_input";
            // 
            // prv_keycode_btn
            // 
            resources.ApplyResources(this.prv_keycode_btn, "prv_keycode_btn");
            this.prv_keycode_btn.Name = "prv_keycode_btn";
            this.prv_keycode_btn.Tag = "KEYCODE_MEDIA_PREVIOUS";
            this.prv_keycode_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // tap_btn
            // 
            resources.ApplyResources(this.tap_btn, "tap_btn");
            this.tap_btn.Name = "tap_btn";
            this.tap_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // divider3
            // 
            resources.ApplyResources(this.divider3, "divider3");
            this.divider3.Name = "divider3";
            // 
            // next_keycode_btn
            // 
            resources.ApplyResources(this.next_keycode_btn, "next_keycode_btn");
            this.next_keycode_btn.Name = "next_keycode_btn";
            this.next_keycode_btn.Tag = "KEYCODE_MEDIA_NEXT";
            this.next_keycode_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // lock_keycode_btn
            // 
            resources.ApplyResources(this.lock_keycode_btn, "lock_keycode_btn");
            this.lock_keycode_btn.Name = "lock_keycode_btn";
            this.lock_keycode_btn.Tag = "KEYCODE_POWER";
            this.lock_keycode_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // vadd_keycode_btn
            // 
            resources.ApplyResources(this.vadd_keycode_btn, "vadd_keycode_btn");
            this.vadd_keycode_btn.Name = "vadd_keycode_btn";
            this.vadd_keycode_btn.Tag = "KEYCODE_VOLUME_UP";
            this.vadd_keycode_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bdiv_keycode_btn
            // 
            resources.ApplyResources(this.bdiv_keycode_btn, "bdiv_keycode_btn");
            this.bdiv_keycode_btn.Name = "bdiv_keycode_btn";
            this.bdiv_keycode_btn.Tag = "KEYCODE_VOLUME_DOWN";
            this.bdiv_keycode_btn.Click += new System.EventHandler(this.button_Click);
            // 
            // keycode_input
            // 
            resources.ApplyResources(this.keycode_input, "keycode_input");
            this.keycode_input.Name = "keycode_input";
            // 
            // divider2
            // 
            resources.ApplyResources(this.divider2, "divider2");
            this.divider2.Name = "divider2";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // api_close
            // 
            resources.ApplyResources(this.api_close, "api_close");
            this.api_close.Name = "api_close";
            this.api_close.Click += new System.EventHandler(this.api_close_Click);
            // 
            // api_run
            // 
            resources.ApplyResources(this.api_run, "api_run");
            this.api_run.Name = "api_run";
            this.api_run.Click += new System.EventHandler(this.api_run_Click);
            // 
            // lang_select
            // 
            resources.ApplyResources(this.lang_select, "lang_select");
            this.lang_select.FormattingEnabled = true;
            this.lang_select.Items.AddRange(new object[] {
            resources.GetString("lang_select.Items"),
            resources.GetString("lang_select.Items1")});
            this.lang_select.Name = "lang_select";
            this.lang_select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            "关于",
            "快捷键设置"});
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.dropdown1_SelectedValueChanged);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::MobileControlGuru.Properties.Resources.ontop_blur;
            this.button5.Ghost = true;
            this.button5.ImageSvg = "";
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // divider5
            // 
            resources.ApplyResources(this.divider5, "divider5");
            this.divider5.Name = "divider5";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.getDevices_btn);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.ipconnect_btn);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.dropdown1);
            this.flowLayoutPanel2.Controls.Add(this.table1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.divider2);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.divider3);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.Controls.Add(this.divider4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Controls.Add(this.divider5);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.lock_keycode_btn);
            this.flowLayoutPanel4.Controls.Add(this.button1);
            this.flowLayoutPanel4.Controls.Add(this.keycode_input);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Controls.Add(this.play_keycode_btn);
            this.flowLayoutPanel5.Controls.Add(this.vadd_keycode_btn);
            this.flowLayoutPanel5.Controls.Add(this.bdiv_keycode_btn);
            this.flowLayoutPanel5.Controls.Add(this.prv_keycode_btn);
            this.flowLayoutPanel5.Controls.Add(this.next_keycode_btn);
            this.flowLayoutPanel5.Controls.Add(this.swipe_up_btn);
            this.flowLayoutPanel5.Controls.Add(this.swipe_down_btn);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label2);
            this.flowLayoutPanel6.Controls.Add(this.x_input);
            this.flowLayoutPanel6.Controls.Add(this.label1);
            this.flowLayoutPanel6.Controls.Add(this.y_input);
            this.flowLayoutPanel6.Controls.Add(this.tap_btn);
            resources.ApplyResources(this.flowLayoutPanel6, "flowLayoutPanel6");
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.button6);
            resources.ApplyResources(this.flowLayoutPanel8, "flowLayoutPanel8");
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            // 
            // flowLayoutPanel7
            // 
            resources.ApplyResources(this.flowLayoutPanel7, "flowLayoutPanel7");
            this.flowLayoutPanel7.Controls.Add(this.api_run);
            this.flowLayoutPanel7.Controls.Add(this.api_close);
            this.flowLayoutPanel7.Controls.Add(this.button4);
            this.flowLayoutPanel7.Controls.Add(this.lang_select);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mian_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mian_FormClosed);
            this.Load += new System.EventHandler(this.Mian_Load);
            this.mini_menustrip.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
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
        private AntdUI.Button lock_keycode_btn;
        private AntdUI.Button api_run;
        private AntdUI.Button api_close;
        private AntdUI.Button button4;
        private AntdUI.InputNumber x_input;
        private AntdUI.Button tap_btn;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.InputNumber y_input;
        private AntdUI.Divider divider2;
        private AntdUI.Button vadd_keycode_btn;
        private AntdUI.Button bdiv_keycode_btn;
        private AntdUI.Button swipe_up_btn;
        private AntdUI.Button swipe_down_btn;
        private AntdUI.Divider divider3;
        private AntdUI.Button prv_keycode_btn;
        private AntdUI.Button next_keycode_btn;
        private AntdUI.Button play_keycode_btn;
        private AntdUI.Divider divider4;
        private AntdUI.Button button1;
        private AntdUI.Input keycode_input;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AntdUI.Button button3;
        private AntdUI.Button button5;
        private AntdUI.Button button6;
        private AntdUI.Divider divider5;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel2;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel3;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel4;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel5;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel6;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel7;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel8;
    }
}

