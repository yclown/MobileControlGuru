using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class ADBKey
    {
        //https://blog.csdn.net/h_bpdwn/article/details/91425599
        public enum Key
        {
            KEYCODE_HOME=3,
            KEYCODE_MENU=82,
            KEYCODE_BACK=4,

            KEYCODE_VOLUME_UP = 24,
            KEYCODE_VOLUME_DOWN = 25,
            KEYCODE_POWER = 26,

            KEYCODE_ENTER = 66,
            KEYCODE_ESCAPE = 111,

            KEYCODE_VOLUME_MUTE = 164,
            KEYCODE_PAGE_UP = 92,
            KEYCODE_PAGE_DOWN = 93,


            #region MEDIA
            KEYCODE_MEDIA_PLAY,
            KEYCODE_MEDIA_PAUSE,
            KEYCODE_MEDIA_STOP,
            KEYCODE_MEDIA_PLAY_PAUSE,
            KEYCODE_MEDIA_FAST_FORWARD,
            KEYCODE_MEDIA_REWIND,
            KEYCODE_MEDIA_NEXT,
            KEYCODE_MEDIA_PREVIOUS,
            KEYCODE_MEDIA_CLOSE, 
            KEYCODE_MEDIA_EJECT,
            KEYCODE_MEDIA_RECORD,
            #endregion
        }
    }
}
