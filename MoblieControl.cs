using AntdUI;
using Microsoft.VisualBasic;
using MobileControlGuru.Base;
using MobileControlGuru.Model;
using MobileControlGuru.Properties;
using MobileControlGuru.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace MobileControlGuru
{
    public partial class MoblieControl : BaseControl
    {

        public Model.Device device { set; get; }
        public MoblieControl()
        {
            InitializeComponent();
        }
        public MoblieControl(Model.Device device)
        {
            resources = new ComponentResourceManager(typeof(MoblieControl));
            InitializeComponent();

            this.device = device;

        }
        private void MoblieControl_Load(object sender, EventArgs e)
        {
            this.input1.Text = device.Name;

            this.checkbox1.Checked=device.Selected; 
            this.wireless_connect.Visible = !this.device.IsTcpIP; 
            this.disconnect.Visible = this.device.IsTcpIP;
            this.ontop.BackgroundImage = this.device.IsTop ? Resources.ontop : Resources.ontop_blur;
            this.disput.Visible= this.device.ScrcpyProcess!=null;
            this.put.Visible = this.device.ScrcpyProcess == null;

            if (device.form != null)
            {
                this.show.Visible = true;
                this.show.BackgroundImage = device.form.Visible? Resources.see: Resources.nosee; 
            }
            else
            {
                this.show.Visible = false;
            }
            
        }

        private void put_Click(object sender, EventArgs e)
        {
            Process process = Scrcpy.Put(this.device.Name); 
            //while (process.MainWindowHandle == IntPtr.Zero)
            //{
            //    Thread.Sleep(100);
            //} 
            //device.form=new ScrcpyForm(device.Name,process);
            //device.ScrcpyProcess= process;
            //device.form.Show();
            //device.form.FormClosed += ScrcpyClosed; 
            DeviceManager.Instance.BindDevicesProcees(this.device.Name, process);
            DeviceManager.Instance.UpdateDevices();
        }

        private void ScrcpyClosed(object sender, FormClosedEventArgs e)
        {
            //device.ScrcpyProcess.Kill();
            device.ScrcpyProcess = null;
            DeviceManager.Instance.UpdateDevices();
        }

        private void checkbox1_CheckedChanged(object sender, bool value)
        {
            device.Selected = value;
             
        }

        private void wireless_connect_Click(object sender, EventArgs e)
        {
           
            string str = Interaction.InputBox("提示信息", "请输入手机IP", "", -1, -1);
            if (string.IsNullOrEmpty(str))
            {
                return;
            }
            ADB.Exec($"-s {this.device.Name} tcpip 5555");
            Thread.Sleep(1000);
            ADB.Connect(str);  
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            DialogResult AF = MessageBox.Show("确定断开连接吗？", "确认框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (AF == DialogResult.OK)
            {
                ADB.Exec("disconnect " + this.device.Name);
                DeviceManager.Instance.UpdateDevices();
            } 
        }

        private void disput_Click(object sender, EventArgs e)
        {
           
            DialogResult AF = MessageBox.Show("确定关闭投屏", "确认框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (AF == DialogResult.OK)
            {

                device.ScrcpyProcess.Kill();
                device.ScrcpyProcess = null;
                device.form?.Dispose();
                device.form = null;
                DeviceManager.Instance.UpdateDevices();
            }
        }

        private void ontop_Click(object sender, EventArgs e)
        {
            this.device.IsTop = !this.device.IsTop;
            ((AntdUI.Button)sender).BackgroundImage = this.device.IsTop ? Resources.to_top : Resources.to_top_blur;
            DeviceManager.Instance.UpdateDevices();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if(this.device.form==null) {
                return;
            }
            var btn = (AntdUI.Button)sender;
            if (this.device.form.Visible)
            {
                this.device.form.Hide();  
            }
            else
            {
                this.device.form.Show();
            }
            btn.BackgroundImage = device.form.Visible ? Resources.see : Resources.nosee;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
