using AntdUI;
using MobileControlGuru.Base;
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
    public partial class ScrcpyForm : BaseForm
    {
        public Process ScrcpyProcess { get; set; }
        IntPtr childHwnd ;
        public string DeviceName { set; get; }
        public ScrcpyForm(string DeviceName, Process ScrcpyProcess)
        {

            this.ScrcpyProcess = ScrcpyProcess;
            this.DeviceName= DeviceName;
            InitializeComponent(); 
        }

        private void ScrcpyForm_Load(object sender, EventArgs e)
        {
            childHwnd = ScrcpyProcess.MainWindowHandle;
            ProcessWindowController.SetParent(childHwnd, this.panel1.Handle);
            
            ProcessWindowController.RECT fx = new ProcessWindowController.RECT();

            ProcessWindowController.GetWindowRect(childHwnd, ref fx);
            int width = fx.Right - fx.Left;                        //窗口的宽度
            int height = fx.Bottom - fx.Top;                   //窗口的高度
            int x = fx.Left;
            int y = fx.Top;
 
            ProcessWindowController.MoveWindow(childHwnd,
                -10, -30,
                this.panel1.Width + 20, this.panel1.Height + 30, true);

            tooltipComponent1.SetTip(home_btn, "主页");
            tooltipComponent1.SetTip(back_btn, "返回");
            //tooltipComponent1.SetTip(home_btn, "主页");
            //tooltipComponent1.SetTip(home_btn, "主页");

        }



        private void ScrcpyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ScrcpyProcess.Kill();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
              
                this.Hide();
                //notifyIcon1.Visible = true;
            }
        }



        private void ScrcpyForm_Resize(object sender, EventArgs e)
        {

            int width = this.panel1.Width;
            int height = this.panel1.Height;
            ProcessWindowController.MoveWindow(childHwnd,
              -10, -30,
              width+20, height+30, true);
        }

        private void inputNumber1_ValueChanged(object sender, decimal value)
        {
             
            ScrcpyForm_Resize(null, null);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            new DeviceADB(DeviceName).SendHome();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new DeviceADB(DeviceName).SendKeyEvent(ADBKey.Key.KEYCODE_BACK);
        }
    }
}
