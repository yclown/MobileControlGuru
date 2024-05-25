using MobileControlGuru.Model;
using MobileControlGuru.Tools;
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
    public partial class HotKeyControl : UserControl
    {
        //public string EventName { get; set; }
        //public string ModifyKey { get; set; }
        //public string Key { get; set; }

        public KeyItem KeyItem { get; set; }
        public HotKeyControl(KeyItem keyItem)
        {
            InitializeComponent();
            this.KeyItem = keyItem;
        }

       
        private void HotKeyControl_Load(object sender, EventArgs e)
        {
            //this.Tag = KeyItem;
            this.EventName.Text= KeyItem.EventName;
            if (ConfigHelp.GetConfig("lang") == "en")
            {
                this.EventName.Text = KeyItem.EventEngName;
            }
            this.ModifyKey.Text= KeyItem.ModifyKey;
            this.Key.Text= KeyItem.Key;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ModifyKey_SelectedValueChanged(object sender, object value)
        {
            AntdUI.Dropdown s = (AntdUI.Dropdown)sender;
            s.Text = value.ToString();
        }

        private void Key_KeyDown(object sender, KeyEventArgs e)
        {
            var input = (AntdUI.Button)sender;
            //KeysConverter keysConverter = new KeysConverter(); 
            //input.Text = keysConverter.ConvertToString(e.KeyCode);
            string keyCode = e.KeyCode.ToString();
            if(keyCode== "ProcessKey")
            {
                return; 
            } 
            input.Text = e.KeyCode.ToString();
        }

        public KeyItem GetData()
        { 
            this.KeyItem.ModifyKey = this.ModifyKey.Text;
            this.KeyItem.Key = this.Key.Text; 
            return this.KeyItem;
        }

      
 
    }
}
