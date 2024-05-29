using AntdUI;
using MobileControlGuru.Base;
using MobileControlGuru.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileControlGuru
{
    public partial class ScrcpySetting : BaseForm
    {
        public ScrcpySetting()
        {
            InitializeComponent();
            resources = new ComponentResourceManager(typeof(ScrcpySetting));
        }

        public void GetParams()
        {
            ScrcpyParam scrcpyParam = new ScrcpyParam() { 
            
                NoAudio= NoAudioSwitch.Checked,
                WindowHeight=WindowHeightInput.Text,
                WindowWidth=WindowWidthInput.Text,
                WindowX=WindowXInput.Text,
                WindowY=WindowYInput.Text,
                KeyboardUhid= KeyboardUhidSwitch.Checked,
                TurnScreenOff=turn_screen_off.Checked,
                StayAwake=stay_awake.Checked,
                AlwaysOnTop= AlwaysOnTop.Checked
            };
            
            ConfigHelp.SetSetting("ScrcpyParamObj", JsonHelp.Obj2Str(scrcpyParam));
            this.Close();
            //return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetParams();
        }

        private void ScrcpySetting_Load(object sender, EventArgs e)
        {
            var scrcpyParam=  JsonHelp.Str2Obj<ScrcpyParam> (ConfigHelp.GetConfig("ScrcpyParamObj"));

            if(scrcpyParam != null)
            {
                NoAudioSwitch.Checked = scrcpyParam.NoAudio;
                WindowHeightInput.Text = scrcpyParam.WindowHeight; 
                WindowWidthInput.Text= scrcpyParam.WindowWidth;
                WindowXInput.Text= scrcpyParam.WindowX;
                WindowYInput.Text= scrcpyParam.WindowY;
                KeyboardUhidSwitch.Checked = scrcpyParam.KeyboardUhid;
                turn_screen_off.Checked= scrcpyParam.TurnScreenOff;
                stay_awake.Checked= scrcpyParam.StayAwake ;
                 AlwaysOnTop.Checked= scrcpyParam.AlwaysOnTop;
            }
            var lang = Tools.ConfigHelp.GetConfig("Lang");
            if (!string.IsNullOrEmpty(lang))
            {
                ChangeLang(lang);
                ApplyResource();
            }
        }

       
    }
}
