using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class ScrcpyParam
    {
        #region audio  params
        [ScrcpyParam("--no-audio")]
        public bool NoAudio { get; set; }



        #endregion

        #region video  params https://github.com/Genymobile/scrcpy/blob/master/doc/video.md
        [ScrcpyParam("--no-video")]
        public bool NoVideo { get; set; }

        #endregion


        #region window params https://github.com/Genymobile/scrcpy/blob/master/doc/window.md
        //[ScrcpyParam("--window-title")]
        //public string WindowTitle { get; set; }
        [ScrcpyParam("--window-x")]
        public string WindowX { get; set; }
        [ScrcpyParam("--window-y")]
        public string WindowY { get; set; }
        [ScrcpyParam("--window-width")]
        public string WindowWidth { get; set; }
        [ScrcpyParam("--window-height")]
        public string WindowHeight { get; set; }

        [ScrcpyParam("--window-borderless")]
        public bool WindowBorderless { get; set; }

        [ScrcpyParam("--always-on-top")]
        public bool AlwaysOnTop { get; set; }
        [ScrcpyParam("--fullscreen")]
        public bool Fullscreen { get; set; }
        [ScrcpyParam("--disable-screensaver")]
        public bool DisableScreensaver { get; set; }


        #endregion




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var properties = typeof(ScrcpyParam).GetProperties();

            foreach (var property in properties)
            {
                Type propertyType = property.PropertyType;

                ScrcpyParamAttribute attr = property.GetCustomAttribute<ScrcpyParamAttribute>();

                switch (propertyType.Name)
                {
                    case "Boolean":
                        if (((bool)property.GetValue(this))) {
                            sb.Append($" {attr.ParamName}");
                        } 
                        break;
                    case "String":
                        if (!string.IsNullOrEmpty(property.GetValue(this).ToString())) {
                            sb.Append($" {attr.ParamName}{attr.ValueSymbol}{property.GetValue(this)}");
                        }
                        break;
                    default:
                         
                        break;
                }
              
            }

            return sb.ToString();
        }
    }
}
