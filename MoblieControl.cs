using MobileControlGuru.Base;
using MobileControlGuru.Model;
using MobileControlGuru.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            InitializeComponent();
            this.device = device;

        }
        private void MoblieControl_Load(object sender, EventArgs e)
        {
            this.input1.Text = device.Name;

            this.checkbox1.Checked=device.Selected;
        }

        private void put_Click(object sender, EventArgs e)
        {
            Process process = Scrcpy.Put(this.device.Name);
            //DeviceManager.Instance.BindDevicesProcees(device.Name, process);
            //process.Exited += new EventHandler(exitHandle);
            while (process.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(100);
            }
            
            device.form=new ScrcpyForm(process); 

            device.form.Show();

            if (process != null)
            {
                ((AntdUI.Button)sender).Visible = false;
            }
        }

        private void checkbox1_CheckedChanged(object sender, bool value)
        {
            device.Selected = value;

            //var a= DeviceManager.Instance.devices;
        }

        private void wireless_connect_Click(object sender, EventArgs e)
        {

        }

        private void disconnect_Click(object sender, EventArgs e)
        {

        }

        private void disput_Click(object sender, EventArgs e)
        {

        }
    }
}
