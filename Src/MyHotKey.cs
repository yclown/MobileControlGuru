using MobileControlGuru.Base;
using MobileControlGuru.Model;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static MobileControlGuru.Base.GlobalHotkey;

namespace MobileControlGuru.Src
{
    /// <summary>
    /// 全局快捷键类
    /// </summary>
    public class MyHotKey
    {
        MobileControlGuru.MainForm mainform { set; get; }

        public MyHotKey(MainForm mainform)
        {
            this.mainform = mainform;
            Register();
        }

        public static List<KeyItem> GetKeyItems()
        {

            var hotkeys = ConfigHelp.GetConfig("hotkeys");
            List<KeyItem> keys = new List<KeyItem>();
            if (string.IsNullOrEmpty(hotkeys))
            {
                keys.Add(new Model.KeyItem()
                {
                    EventName = "锁屏",
                    EventEngName = "Lock",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.DeviceLock,
                    Key = Keys.D.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "主页",
                    EventEngName = "Home",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.Home,
                    Key = Keys.H.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "音量加",
                    EventEngName = "VolumeUp",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.VolumeUp,
                    Key = Keys.Up.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "音量减",
                    EventEngName = "VolumeDown",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.VolumeDown,
                    Key = Keys.Down.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "前一个(媒体)",
                    EventEngName = "MediaPrevious",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.MediaPrevious,
                    Key = Keys.Left.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "后一个(媒体)",
                    EventEngName = "MediaNext",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.MediaPrevious,
                    Key = Keys.Right.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "播放暂停(媒体)",
                    EventEngName = "MediaPlayPause",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.MediaPlayPause,
                    Key = Keys.NumPad5.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "上滑",
                    EventEngName = "SwipeUP",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.SwipeUP,
                    Key = Keys.NumPad2.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "下滑",
                    EventEngName = "SwipeDown",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.SwipeDown,
                    Key = Keys.NumPad8.ToString()
                });
                keys.Add(new Model.KeyItem()
                {
                    EventName = "点击屏幕",
                    EventEngName = "FastTap",
                    ModifyKey = "Alt",
                    EventID = (int)MyHotKey.Event.FastTap,
                    Key = Keys.C.ToString()
                });

            }
            else
            {
                keys = Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyItem>>(hotkeys);
            }

            return keys;

        }

        /// <summary>
        /// 注册快捷键
        /// </summary>
       
        public void Register()
        { 
           
            
            foreach (KeyItem key in GetKeyItems() )
            {
                    
                    
                Keys selfkey = (Keys)new KeysConverter().ConvertFromInvariantString(key.Key);
                if (key.ModifyKey == "Ctrl+Alt")
                {
                    RegisterHotKey(mainform.Handle, key.EventID, KeyModifiers.Alt|KeyModifiers.Ctrl, selfkey);
                }
                else if (key.ModifyKey == "Ctrl") {
                    RegisterHotKey(mainform.Handle, key.EventID, KeyModifiers.Ctrl, selfkey);
                }
                else
                {
                    RegisterHotKey(mainform.Handle, key.EventID, KeyModifiers.Alt, selfkey);
                }
                    
            }
             
        }


        /// <summary>
        /// 取消注册快捷键
        /// </summary>
        public void UnRegister()
        {
             
            UnregisterHotKey(mainform.Handle, (int)Event.VolumeUp);
            UnregisterHotKey(mainform.Handle, (int)Event.VolumeDown);
            UnregisterHotKey(mainform.Handle, (int)Event.MediaPrevious);
            UnregisterHotKey(mainform.Handle, (int)Event.MediaNext);
            UnregisterHotKey(mainform.Handle, (int)Event.SwipeUP);
            UnregisterHotKey(mainform.Handle, (int)Event.SwipeDown);
            UnregisterHotKey(mainform.Handle, (int)Event.MediaPlayPause);
            UnregisterHotKey(mainform.Handle, (int)Event.FastTap);
            UnregisterHotKey(mainform.Handle, (int)Event.Home);
        }
        /// <summary>
        /// 事件类型
        /// </summary>
        public enum Event
        {
            DeviceLock = 100,
            ScreenPut,
            ScreenPutOff,
            VolumeUp ,
            VolumeDown ,
            MediaPrevious,
            MediaNext,
            MediaPlayPause,
            SwipeUP,
            SwipeDown,
            FastTap,
            Home,
            //MediaNext,
            //MediaNext,

        }
        /// <summary>
        /// 事件处理
        /// </summary>
       
        public  void Deal(MainForm main, int WParam)
        {
            Model.Device device=  main.deviceItems.Where(n => n.IsSelected).FirstOrDefault();
            if (device == null)
            {
                device = DeviceManager.Instance.devices.FirstOrDefault(); 
            } 
            if(device == null)
            {
                return;
            }
            var dd = new DeviceADB(device.Name);
            switch (WParam)
            {
                case (int)Event.DeviceLock:
                    
                    if (device != null) {
                        if(device.ScrcpyProcess!= null)
                        {
                            ProcessWindowController.MinimizeProcessWindow(device.ScrcpyProcess.Id);  
                        }
                        dd.SendLock();
                    } 
                    break;
                case (int)Event.VolumeDown:

                    if (device != null)
                    {
                        dd.SendKeyEvent(ADBKey.Key.KEYCODE_VOLUME_DOWN);
                    }
                    break;
                case (int)Event.VolumeUp: 
                    if (device != null)
                    {
                        dd.SendKeyEvent( ADBKey.Key.KEYCODE_VOLUME_UP);
                    }
                    break;
                case (int)Event.MediaNext:
                    if (device != null)
                    {
                        dd.SendKeyEvent( ADBKey.Key.KEYCODE_MEDIA_NEXT);
                    }
                    break;
                case (int)Event.MediaPrevious:
                    if (device != null)
                    {
                        dd.SendKeyEvent( ADBKey.Key.KEYCODE_MEDIA_PREVIOUS);
                    }
                    break;
                case (int)Event.SwipeDown:
                    if (device != null)
                    {
                        dd.SendSwipeDown();
                    }
                    break;
                case (int)Event.SwipeUP:
                    if (device != null)
                    {
                        dd.SendSwipeUp();
                    }
                    break; 
                case (int)Event.MediaPlayPause:
                    if (device != null)
                    {
                        dd.SendKeyEvent(ADBKey.Key.KEYCODE_MEDIA_PLAY_PAUSE);
                    }
                    break;
                case (int)Event.FastTap:
                    if (device != null)
                    {
                        dd.TapScreen(main.point);
                    }
                    break;
                case (int)Event.Home:
                    if (device != null)
                    {
                        dd.SendHome();
                    }
                    break;
            }
        }
    }
}
