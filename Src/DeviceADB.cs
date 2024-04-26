using MobileControlGuru.Base;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru.Src
{
    /// <summary>
    /// 设备ADB操作类
    /// </summary>
    public class DeviceADB
    {
        public string DeviceName { set; get; }

        public DeviceADB(string deviceName)
        {
            if (Common.IsValidIP(deviceName)) {
                DeviceName = GetDevice(deviceName);
            }
            else
            {
                DeviceName = deviceName;
            }
            
        }
        /// <summary>
        /// 检查设备在线状态
        /// </summary>
        /// <returns></returns>
        public bool CheckOnline()
        {
            Model.Device d = null;
            if (Common.IsValidIP(DeviceName))
            {
                DeviceName = DeviceName.Split(':')[0]+":";
            }
            d = DeviceManager.Instance.devices.Where(n =>n.Status=="device"&& n.Name.StartsWith(DeviceName)).FirstOrDefault();
            
            return d!=null;
        }
        /// <summary>
        /// 获取设备，如果是ip设备责只关心ip不关心端口号
        /// </summary>
        /// <param name="deviceIP"></param>
        /// <returns></returns>
        public string GetDevice(string deviceIP)
        {
            deviceIP= deviceIP.Split(':')[0];    
            var d= DeviceManager.Instance.devices.Where(n=>n.Name.StartsWith(deviceIP+":")).FirstOrDefault();
            return d.Name;
        }
        /// <summary>
        /// 发送按键
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public AdbParse SendKeyEvent( ADBKey.Key key)
        {

            var res = ADB.Exec($"-s {DeviceName} shell input keyevent {key}");

            return res;

        }
        /// <summary>
        /// 发送按键
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public AdbParse SendKeyEvent( string key)
        {

            var res = ADB.Exec($"-s {DeviceName} shell input keyevent {key}");
            return res;
        }
        /// <summary>
        /// 发送滑动命令
        /// </summary>
        /// <param name="form"></param>
        /// <param name="to"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public AdbParse SendSwipe(Point form, Point to, int delta = 100)
        {
            var res = ADB.Exec($"-s {DeviceName} shell input swipe {form.X} {form.Y} {to.X} {to.Y} {delta}");
            return res;
        }
       
        /// <summary>
        /// 下滑
        /// </summary>
        /// <returns></returns>
        public AdbParse SendSwipeDown()
        {
            var res = SendSwipe( new Point(540, 500), new Point(540, 1300));
            return res;
        }
        /// <summary>
        /// 上滑
        /// </summary>
        /// <returns></returns>
        public AdbParse SendSwipeUp()
        {
            var res = SendSwipe( new Point(540, 1300), new Point(540, 500));
            return res;
        }
        /// <summary>
        /// 发送锁屏
        /// </summary>
        /// <returns></returns>
        public AdbParse SendLock()
        {
            var res =SendKeyEvent(ADBKey.Key.KEYCODE_POWER);
            return res;
        }
        public AdbParse SendHome()
        {
            var res = SendKeyEvent(ADBKey.Key.KEYCODE_HOME);
            return res;
        }
        public AdbParse TapScreen(Point point)
        {
            var res = ADB.Exec($"-s {DeviceName} shell input tap  {point.X} {point.Y} ");
            return res;
        }


        public AdbParse ScreenCap()
        {
            var basepath = ConfigHelp.GetConfig("DeivesDir");
            if(basepath == null)
            {
                basepath = Directory.GetCurrentDirectory();
                ConfigHelp.SetSetting("DeivesDir", basepath);
            }


            var pathDir = Path.Combine(basepath, GetOkFileName(DeviceName), "ScreenCap");
            if (!Directory.Exists(pathDir)) {
                Directory.CreateDirectory(pathDir);
            }

            var savePath = Path.Combine(pathDir, DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".png");
            var res= ADB.Screencap(DeviceName, savePath);
            return res;
        }

        private string GetOkFileName(string strFile)
        {
            //string strFileName = "文件名称";
            StringBuilder rBuilder = new StringBuilder(strFile);
            foreach (char rInvalidChar in Path.GetInvalidFileNameChars())
                rBuilder.Replace(rInvalidChar.ToString(), string.Empty);

            strFile = rBuilder.ToString().Trim();
            strFile = strFile.Replace("+", "");
            return strFile;
        }
    }
}
