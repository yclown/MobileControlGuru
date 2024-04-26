using AntdUI;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using MobileControlGuru.Base;
using MobileControlGuru.Model;
using MobileControlGuru.Properties;
using MobileControlGuru.Src;
using MobileControlGuru.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MobileControlGuru
{
    public partial class MainForm : Form
    {
      
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
        WebAPI.WebHelper webservice = new WebAPI.WebHelper();
        private MyHotKey hotkey;

        public MainForm()
        {
            InitializeComponent();

            this.Resize += new EventHandler(MainForm_Resize);
            DeviceManager.Instance.updateDelegates += UpdateDeviceInfo;
            this.api_close.Visible = false;
        }
       

        private void Mian_Load(object sender, EventArgs e)
        {

            InitScrcpy();
            InitTable(); 
            hotkey = new MyHotKey(this);
            webservice = new WebAPI.WebHelper();
            DeviceManager.Instance.UpdateDevices();
        }
        private void InitScrcpy()
        {
            if (!Scrcpy.ChcekScrcpyPATH())
            {
                Scrcpy.ExtractScrcpyZip(Directory.GetCurrentDirectory());
            } 
        }

        #region table
         
        private void InitTable()
        {
            AntdUI.Column[] cols = new Column[] { 
                new AntdUI.ColumnCheck("IsSelected"), 
                new AntdUI.Column("Name", resources.GetString("tableNameText")),
                 new AntdUI.Column("status", resources.GetString("tableStatusText")),
                new AntdUI.Column("btns", resources.GetString("tablebtnsText")),
               

            };

            this.table1.Columns = cols;
            this.table1.EmptyText = resources.GetString("tableNoDataText");// "暂无设备，请连接设备后刷新";

        }
        public AntdUI.AntList<DeviceItem> deviceItems = new AntList<DeviceItem>();
        public void UpdateDeviceInfo()
        {
            deviceItems = new AntList<DeviceItem>();
            foreach (var item in DeviceManager.Instance.devices)
            {
                deviceItems.Add(new DeviceItem(item));
            }
            this.table1.Binding(deviceItems);
        }

        /// <summary>
        /// 列表 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="btn"></param>
        /// <param name="args"></param>
        /// <param name="record"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        private void table1_CellButtonClick(object sender, CellLink btn, MouseEventArgs args, object record, int rowIndex, int columnIndex)
        {
            Model.DeviceItem deviceItem = (Model.DeviceItem)record;
            var d = DeviceManager.Instance.GetDevice(deviceItem.Name);
            Process process = null;
            switch (btn.Id)
            {
                case "usb_put":
                    process = Scrcpy.UsbPut(deviceItem.Name);

                    DeviceManager.Instance.BindDevicesProcees(deviceItem.Name, process);
                    break;

                case "ip_put":
                    process = Scrcpy.IPPut(deviceItem.Name);
                    DeviceManager.Instance.BindDevicesProcees(deviceItem.Name, process);
                    //d.monitor = new ScrcpyMonitor(d.Name);
                    //d.monitor.main = this;
                    //d.monitor.Start();
                    break;
                case "close_put":
                    if (d.ScrcpyProcess != null)
                    {
                        if (!d.ScrcpyProcess.HasExited)
                        {
                            d.ScrcpyProcess.Kill(); // 强制结束进程
                        }
                        d.ScrcpyProcess = null;
                    }

                    break; 
                case "disconnected":
                    if (d.ScrcpyProcess != null)
                    {
                        if (!d.ScrcpyProcess.HasExited)
                        {
                            d.ScrcpyProcess.Kill(); // 强制结束进程
                        }
                        d.ScrcpyProcess = null;
                    }
                    ADB.Exec("disconnect " + d.Name);
                    DeviceManager.Instance.UpdateDevices();
                    break;
            }
            DeviceManager.Instance.UpdateDevices();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DeviceManager.Instance.UpdateDevices();
        }
       
        private void dropdown1_SelectedValueChanged(object sender, object value)
        {
            
        }

        private void exit_tsmi_Click(object sender, EventArgs e)
        {
            DeviceManager.Instance.CloseAll();
            hotkey.UnRegister();
            System.Environment.Exit(System.Environment.ExitCode);
            this.Dispose();
            this.Close();
        }
        
        private void ipconnect_btn_Click(object sender, EventArgs e)
        {
            IPConnect iPConnect = new IPConnect(this);
            iPConnect.StartPosition = FormStartPosition.CenterParent;
            iPConnect.ShowDialog(this);
        }

         
        #region I18n
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Tools.ConfigHelp.SetSetting("Lang", "zh-CN");
                ChangeLang("zh-CN");
            }
            else
            {
                Tools.ConfigHelp.SetSetting("Lang", "en");
                ChangeLang("en"); 
            }  
        }

        private void ChangeLang(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ApplyResource();
        }
      
        // 遍历控件，并根据资源文件替换相应属性
        private void ApplyResource()
        {
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            resources.ApplyResources(this, "$this");
            InitTable();
        }

        #endregion
       


        #region 全局快捷键
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {

            const int WM_HOTKEY = 0x0312;
           
            switch (m.Msg)
            {
                //监听快捷键 消息
                case WM_HOTKEY:
                    hotkey.Deal(this,m.WParam.ToInt32()); 
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        // 窗口已经被最小化  
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
               

            }
        }
        private void Mian_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 检查关闭的原因是否为用户操作（CloseReason.UserClosing）
            DeviceManager.Instance.CloseAll();
            hotkey.UnRegister();
        }

        


        private void Mian_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                // 隐藏主窗体而不是退出
                this.Hide();  
                notifyIcon1.Visible = true; 
            }
        }

        private void main_tsmi_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var datas = (AntList<Model.DeviceItem>)this.table1.DataSource;
            var selecteds = datas.Where(n => n.IsSelected).ToList();

            ADB.Lock(selecteds);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true; // 设置为文件夹选择器  
                dialog.Multiselect = false; // 允许选择多个文件夹  
                dialog.Title = "请选择文件夹"; // 设置对话框标题  
                dialog.DefaultFileName = "Scrcpy";
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var s= dialog.FileName;
                    Scrcpy.ExtractScrcpyZip(s);
                }
            }
        }

        

        private void api_run_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckAdminPrivileges())
                {

                    if (webservice.Runnig) {
                        System.Diagnostics.Process.Start("explorer.exe", webservice.Url + "/swagger");
                    }
                    else
                    {
                        webservice.Run(); 
                        webservice.Runnig = true;
                        //System.Diagnostics.Process.Start("explorer.exe", webservice.Url + "/swagger");
                        this.api_close.Visible = true;
                    } 
                    ((AntdUI.Button)sender).Text = "查看文档";
                }
                else
                {
                    MessageBox.Show("API服务需要以管理员方式打开，如果需要请以管理方式重启应用");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void api_close_Click(object sender, EventArgs e)
        {
            DialogResult AF = MessageBox.Show("确定关闭API服务吗？", "确认框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (AF == DialogResult.OK)
            {
                webservice?.Dispose();
                this.api_run.Text = "开启API";
                ((AntdUI.Button)sender).Visible = false;
            }

            else
            {
                //用户点击取消或者关闭对话框后执行的代码
            }

          
        }
        private bool CheckAdminPrivileges()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            bool isAdministrator = principal.IsInRole(WindowsBuiltInRole.Administrator);
            return isAdministrator;
           
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScrcpySetting scrcpysetting = new ScrcpySetting();
            scrcpysetting.StartPosition = FormStartPosition.CenterParent;
            scrcpysetting.ShowDialog(this);
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ScrcpyConrtrolPanel scrcpysetting = new ScrcpyConrtrolPanel();
            //scrcpysetting.StartPosition = FormStartPosition.CenterParent;
            scrcpysetting.Show();
        }

        #region scrcpy 控制器
        ScrcpyConrtrolPanel conrtrolPanel = new ScrcpyConrtrolPanel();
        public void ShowControl(Device device)
        {
            //conrtrolPanel.StartPosition = FormStartPosition.CenterParent;
            conrtrolPanel.Device = device;
            conrtrolPanel.ShowInTaskbar = false;
            conrtrolPanel.Activate();
            conrtrolPanel.Show();
        }
        public void HideControl()
        {

            conrtrolPanel.Show();
        }

        public void SetControl(ProcessWindowController.RECT fx)
        {

           
            int x = fx.Right;
            int y = fx.Top;
            int width = fx.Right - fx.Left;                        //窗口的宽度
            //int height = fx.Bottom - fx.Top;
            conrtrolPanel.Location=new Point(x, y);
            //conrtrolPanel.Width = width;
            //conrtrolPanel.Height = fx.Top - fx.Bottom;
           


        }

        #endregion

        private void setting_tmsi_Click(object sender, EventArgs e)
        {
            ScrcpySetting scrcpysetting = new ScrcpySetting();
            scrcpysetting.StartPosition = FormStartPosition.CenterParent;
            scrcpysetting.ShowDialog(this);
        }
        public Point point=new Point();
        private void button5_Click_1(object sender, EventArgs e)
        {
            point= new Point(Convert.ToInt32(x_input.Text), Convert.ToInt32(y_input.Text));
            var dlist= this.deviceItems.Where(n => n.IsSelected).ToList();
            
            foreach( var ditem in dlist) {
                new DeviceADB(ditem.Name).TapScreen(point);
            }
            
             
        }
    }
}
