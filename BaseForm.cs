using MobileControlGuru.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru
{
    public class BaseForm : Form
    {
        ComponentResourceManager resources;
        public BaseForm()
        {
            resources = new ComponentResourceManager();
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
           
        }

    }
}
