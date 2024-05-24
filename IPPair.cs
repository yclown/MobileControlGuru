using MobileControlGuru.Base;
using MobileControlGuru.Properties;
using MobileControlGuru.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru
{
    public partial class IPPair : BaseForm
    {
        public MobileControlGuru.MainForm main { set; get; }
        public IPPair(MobileControlGuru.MainForm _main)
        {
            this.main = _main;
            InitializeComponent();
            resources = new ComponentResourceManager(typeof(IPConnect));
        }



        private void connect_btn_Click(object sender, EventArgs e)
        {
            string device_ip = this.ip_input.Text;
            int port = Convert.ToInt32(this.port_input.Text);
            int code =Convert.ToInt32( this.code_input.Text);
            var adbinfo = ADB.Pair(device_ip,port, code);
            DeviceManager.Instance.UpdateDevices();
            Properties.Settings.Default.LastDeviceIP = device_ip;
            Properties.Settings.Default.Save();
            this.Close();
        }

 
      
 
    }
}
