using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru
{
    public partial class BaseControl : UserControl
    {

        public ComponentResourceManager resources;
        public BaseControl()
        {
            InitializeComponent();
        }

        public void ChangeLang(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

        }
        public void ApplyResource()
        {
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            resources.ApplyResources(this, "$this"); 
        }

        private void BaseControl_Load(object sender, EventArgs e)
        {
            var lang = Tools.ConfigHelp.GetConfig("Lang");
            if (!string.IsNullOrEmpty(lang))
            {
                ChangeLang(lang);
                ApplyResource();
            }
        }
    }
}
