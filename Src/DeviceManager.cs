using MobileControlGuru.Base;
using MobileControlGuru.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileControlGuru.Src
{
    /// <summary>
    /// 全局设备管理类
    /// </summary>
    public class DeviceManager
    {
        public delegate void UpdateDelegate();

        /// <summary>
        /// 更行设备信息委托
        /// </summary>
        public UpdateDelegate updateDelegates;
        public List<Device> devices { set; get; }

        private static DeviceManager instance = null;
        private static readonly object lockObj = new object();

        private DeviceManager() { }
        /// <summary>
        /// 单例模式
        /// </summary>
        public static DeviceManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new DeviceManager();
                            instance.devices = new List<Device>();
                        }
                    }
                }
                return instance;
            }
        } 

         
        /// <summary>
        /// 更新设备列表
        /// </summary>
        public  void UpdateDevices()
        {
            var data = ADB.GetDeiveces();

            List<string> newDevices = data.Select(n => n.Name).ToList();
            List<string> oldDevices = DeviceManager.Instance.devices.Select(n => n.Name).ToList();

            //删除不在的
            var needRemove = DeviceManager.Instance.devices.Where(n => !newDevices.Contains(n.Name)).ToList(); 
            foreach (var r in needRemove)
            {
                if (r.ScrcpyProcess != null)
                {
                    r.ScrcpyProcess.Dispose();
                }
                DeviceManager.Instance.devices.Remove(r);
            }
            //添加新的
            var addItems = data.Where(n => !oldDevices.Contains(n.Name)).ToList();
            DeviceManager.Instance.devices = DeviceManager.Instance.devices.Concat(addItems).OrderByDescending(n=>n.IsTop).ToList();
             
            //状态更新
            foreach(var r in DeviceManager.Instance.devices)
            {
                var d=data.Where(n=>n.Name == r.Name).FirstOrDefault();
                if(d != null)
                {
                    r.Status=d.Status;
                } 
            }


            updateDelegates();
        }
        /// <summary>
        /// 绑定scrcpy 到设备
        /// </summary>
        /// <param name="devicename"></param>
        /// <param name="process"></param>
        public  void BindDevicesProcees(string devicename, Process process)
        {

            var d = GetDevice(devicename);
            d.ScrcpyProcess = process;
            d.ScrcpyProcess.Exited += new EventHandler(exitHandle);
            updateDelegates();
        }
        /// <summary>
        /// scrcpy 进程退出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void exitHandle(object sender, EventArgs e)
        {
            var p = (Process)sender;
            var d = DeviceManager.Instance.devices.
                Where(n => n.ScrcpyProcess != null && n.ScrcpyProcess.Id == p.Id).FirstOrDefault();
            if (d != null)
            {
                d.ScrcpyProcess = null;
                if (d.monitor != null)
                {
                    d.monitor.Stop();
                }
                
            }
            DeviceManager.Instance.UpdateDevices();
        }

        public Device GetDevice(string name)
        {
            var d = DeviceManager.Instance.devices.Where(n => n.Name == name).FirstOrDefault();
            return d;

        }


        public void CloseAll()
        {
            foreach(var d in devices)
            {
                Close(d); 

            }  
        }
        public void Close(Device d)
        {
          
            if (d.monitor != null)
            {
                d.monitor.Stop();
            }
            if (d.ScrcpyProcess != null)
            {
                if (!d.ScrcpyProcess.HasExited)
                {
                    d.ScrcpyProcess.Kill(); // 强制结束进程
                }

            }
 
        }
    }
}
