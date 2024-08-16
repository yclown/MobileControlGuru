using MobileControlGuru.Base;
using MobileControlGuru.Src;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MobileControlGuru.WebAPI.Controllers
{
    public class DeviceController : ApiController
    {
        /// <summary>
        /// 设备列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string List()
        {
            return string.Join(",", DeviceManager.Instance.devices.Select(n => n.Name));

        }

        /// <summary>
        /// 检查设备在线情况
        /// </summary>
        /// <param name="devicename"></param>
        /// <returns></returns>
        [HttpGet]
        public string CheckOnline(string devicename)
        {
            if(new DeviceADB(devicename).CheckOnline())
            {
                return "online";
            }
            else
            {
                return "offline";
            }
        }
        /// <summary>
        /// 连接设备
        /// </summary>
        /// <param name="devicename">设备名/IP</param>
        /// <returns></returns>
        [HttpGet]
        public string Connect(string devicename)
        {

            var res= ADB.Connect(devicename);
            
            return res.Message;
        }

        /// <summary>
        /// 无线授权调试
        /// </summary>
        /// <param name="devicename">设备IP</param>
        /// <param name="port">端口号</param>
        /// <param name="code">6位配对码</param>
        /// <returns></returns>
        [HttpGet]
        public string Pair(string devicename,int port,int code)
        {

            var res = ADB.Pair(devicename,port,code);

            return res.Message;
        }

        /// <summary>
        /// 发送锁屏键
        /// </summary>
        /// <param name="devicename">设备名/IP</param>
        /// <returns></returns>
        [HttpGet] 
        public string Lock(string devicename)
        {
            var res = new DeviceADB(devicename).SendLock();
            return res.Message;
        }


        /// <summary>
        /// 发送自定义按键 
        /// </summary>
        /// <param name="devicename">设备名/IP</param>
        /// <param name="Key">按键范围应当在正常的范围内</param>
        /// <returns></returns>
        [HttpGet]
        public string SendKey(string devicename,string Key)
        {

            var res = new DeviceADB(devicename).SendKeyEvent( Key);
            return res.Message;
        }
        /// <summary>
        /// 屏幕滑动 
        /// </summary>
        /// <param name="devicename">设备名/IP</param>
        /// <param name="direct">up表示上滑，在短视频里就表示下一个</param>
        /// <returns></returns>
        [HttpGet]
        public string SendSwipe(string devicename, string direct)
        {
            var res = new AdbParse("","");
            if (direct == "up")
            {
                res= new DeviceADB(devicename).SendSwipeUp();
            }
            else
            {
                res= new DeviceADB(devicename).SendSwipeDown();
            }

            return res.Message;
        }

        /// <summary>
        /// 屏幕点击
        /// </summary>
        /// <param name="devicename"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [HttpGet]
        public string SendTap(string devicename, int x,int y)
        {
            var res = new DeviceADB(devicename).TapScreen(new Point(x, y));
            

            return res.Message;
        }
    }
}
