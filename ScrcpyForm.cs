using AntdUI;
using MobileControlGuru.Base;
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
        float Rate = 1;
        public ScrcpyForm(Process ScrcpyProcess)
        {

            this.ScrcpyProcess = ScrcpyProcess;
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

            //width =  ;
            Rate = (float)width / height;
            this.inputNumber1.Value = (decimal)Rate;
            ProcessWindowController.MoveWindow(childHwnd, 
                this.panel1.Width / 2 - width / 2, 0, 
                (int)(Rate* this.panel1.Height), this.panel1.Height, true);
        }

        private void ScrcpyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ScrcpyProcess.Kill();
           
        }

        private void ScrcpyForm_Resize(object sender, EventArgs e)
        {

            int width = (int)(Rate * this.panel1.Height);
            int height = this.panel1.Height;
            ProcessWindowController.MoveWindow(childHwnd,
               this.panel1.Width / 2 - width / 2, 0,
              width, height, true);
        }

        private void inputNumber1_ValueChanged(object sender, decimal value)
        {

            this.Rate = (float)value;
            ScrcpyForm_Resize(null, null);
        }
    }
}
