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

namespace MobileControlGuru.AutoTask
{
    public partial class SelectDevice : Form
    {
        public SelectDevice()
        {
            InitializeComponent();
        }

        private void SelectDevice_Load(object sender, EventArgs e)
        {
            this.select1.Items =new AntdUI.BaseCollection();
            foreach(var d in DeviceManager.Instance.devices)
            {
                this.select1.Items.Add(d.Name);
            }
            this.select1.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
