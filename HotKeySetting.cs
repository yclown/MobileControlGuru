using AntdUI;
using MobileControlGuru.Model;
using MobileControlGuru.Src;
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
    public partial class HotKeySetting : BaseForm
    {
        public Src.MyHotKey myHotKey { set; get; }
        public HotKeySetting(Src.MyHotKey myHotKey)
        {
            InitializeComponent();
            resources = new ComponentResourceManager(typeof(HotKeySetting));
            this.myHotKey = myHotKey;
        }

        private void HotKeySetting_Load(object sender, EventArgs e)
        {
            foreach (var item in MyHotKey.GetKeyItems())
            {

                HotKeyControl htc = new HotKeyControl(item); 
                this.flowLayoutPanel1.Controls.Add(htc);
            }
             
        }
        /// <summary>
        /// 初始化快捷键
        /// </summary>
        /// <returns></returns>
        
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                ConfigHelp.SetSetting("hotkeys", GetSetting());
                myHotKey.UnRegister();
                myHotKey.Register();
                MessageBox.Show("设置成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private string GetSetting()
        {
            var keyssetting=  new List<KeyItem>();
            foreach(HotKeyControl control in this.flowLayoutPanel1.Controls)
            {
                keyssetting.Add(control.GetData());
            }

            return Newtonsoft.Json.JsonConvert.SerializeObject(keyssetting);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            var input = (AntdUI.Button)sender;
            //KeysConverter keysConverter = new KeysConverter(); 
            //input.Text = keysConverter.ConvertToString(e.KeyCode);
            input.Text = e.KeyCode.ToString();
        }


    }
}
