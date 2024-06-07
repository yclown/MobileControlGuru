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
        public ComponentResourceManager resources;
        public BaseForm()
        {
            //resources = new ComponentResourceManager();
        }

        public void ChangeLang(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        public void ApplyResource()
        {
            //foreach (Control ctl in this.Controls)
            //{
            //    resources.ApplyResources(ctl, ctl.Name);

            //    if (ctl.Controls.Count>0 )
            //    {


            //    }
            //}
            Apply(this.Controls);
            this.ResumeLayout(false);
            this.PerformLayout();
            resources.ApplyResources(this, "$this"); 
         
        }


        public void Apply(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                if(ctl.Controls.Count>0)
                {
                    Apply(ctl.Controls);
                }
               
            }
        }
    }
}
