using MobileControlGuru.Base;
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


        /// <summary>
        /// 注册快捷键
        /// </summary>
       
        public  void Register()
        { 
            RegisterHotKey(mainform.Handle, (int)Event.DeviceLock, KeyModifiers.Alt, Keys.D);
            RegisterHotKey(mainform.Handle, (int)Event.VolumeUp, KeyModifiers.Alt, Keys.Up);
            RegisterHotKey(mainform.Handle, (int)Event.VolumeDown, KeyModifiers.Alt, Keys.Down);
            RegisterHotKey(mainform.Handle, (int)Event.MediaPrevious, KeyModifiers.Alt, Keys.Left);
            RegisterHotKey(mainform.Handle, (int)Event.MediaNext, KeyModifiers.Alt, Keys.Right);
            RegisterHotKey(mainform.Handle, (int)Event.SwipeUP, KeyModifiers.Alt, Keys.NumPad2);
            RegisterHotKey(mainform.Handle, (int)Event.SwipeDown, KeyModifiers.Alt, Keys.NumPad8);
            RegisterHotKey(mainform.Handle, (int)Event.MediaPlayPause, KeyModifiers.Alt, Keys.NumPad5);
            RegisterHotKey(mainform.Handle, (int)Event.FastTap, KeyModifiers.Alt, Keys.C);
            RegisterHotKey(mainform.Handle, (int)Event.Home, KeyModifiers.Alt, Keys.H);

            //RegisterHotKey(Handle, (int)Event.MediaPlayPause, KeyModifiers.Alt| KeyModifiers.Ctrl, Keys.NumPad5); 
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
