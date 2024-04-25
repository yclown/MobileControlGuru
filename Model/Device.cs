using AntdUI;
using MobileControlGuru.Src;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AntdUI.Modal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileControlGuru.Model
{
    /// <summary>
    /// 设备模型类
    /// </summary>
    public class Device
    {
        public string Name { get; set; }
        public Process ScrcpyProcess { get; set; }
        public string ScrcpyParams { get; set; }

        public string Status { set; get; }
        //public IntPtr hook { set; get; }
        public ScrcpyMonitor monitor { set; get; }
        //public bool IsTcpIP { get; set; }
    }
  


    public enum PutType
    {
        None = 0,
        Puted = 1,
        
    }
    /// <summary>
    /// table 的模型类
    /// </summary>
    public class DeviceItem : Device
    {
        public bool IsSelected { get; set; }

        public bool IsTcpIP { get; set; }
        public PutType PutType { get; set; }
        public AntdUI.ICell[] btns { get; set; } 
        public AntdUI.ICell status { get; set; } 

       
        public DeviceItem(Device device)
        {
            this.Name = device.Name;
            this.PutType = PutType.None;
            this.IsTcpIP = Tools.Common.IsValidIP(device.Name);
            var btns = new List<ICell>();
            if(device.Status== "device")
            {
                
                if (!IsTcpIP)
                {
                    btns.Add(new AntdUI.CellButton("usb_put", "有线投屏", AntdUI.TTypeMini.Success));
                    
                }
                else
                {
                    btns.Add(new AntdUI.CellButton("ip_put", "无线投屏", AntdUI.TTypeMini.Success));
                    
                } 
                if (device.ScrcpyProcess != null)
                {
                    this.PutType = PutType.Puted;
                    btns.Add(new AntdUI.CellButton("close_put", "停止投屏", AntdUI.TTypeMini.Error));
                }
                //btns.Add(new AntdUI.CellButton("put_params", "投屏参数", AntdUI.TTypeMini.Primary));
                status = new AntdUI.CellText("在线", Color.Green);

               
            }
            else
            {
                status=new AntdUI.CellText("离线", Color.Gray);
            }

            btns.Add(new AntdUI.CellButton("disconnected", "断开连接", AntdUI.TTypeMini.Error));

            this.btns = btns.ToArray();
        }


    }
 
       
    
}
