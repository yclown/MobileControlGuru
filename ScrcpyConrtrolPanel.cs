using AntdUI;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru
{
    public partial class ScrcpyConrtrolPanel : Window
    {

        public Device Device { get; set; }
        public ScrcpyConrtrolPanel()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            // 设置窗体的背景色为 LimeGreen，并将其设为透明色
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
            //this.FormBorderStyle = FormBorderStyle.None;
        }
 

        private void screencap_btn_Click(object sender, EventArgs e)
        {

            new DeviceADB(Device.Name).ScreenCap();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            new DeviceADB(Device.Name).SendHome();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            ADB.SendKeyEvent(Device.Name, ADBKey.Key.KEYCODE_BACK);
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            

            DialogResult AF = MessageBox.Show("确定关闭投屏吗？", "确认框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (AF == DialogResult.OK)
            {
                DeviceManager.Instance.Close(Device);
                DeviceManager.Instance.UpdateDevices();
                this.Hide(); 
            } 
            else
            {
                //用户点击取消或者关闭对话框后执行的代码
            }
        }
    }
}
