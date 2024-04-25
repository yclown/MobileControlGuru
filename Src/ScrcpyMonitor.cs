using MobileControlGuru.Model;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static MobileControlGuru.Base.ProcessWindowController;
namespace MobileControlGuru.Src
{
    public class ScrcpyMonitor
    {
        public Device  Device { get { 
                return DeviceManager.Instance.GetDevice(DeviceName);
            }
        }
        public string  DeviceName { get; set; }
        public MainForm main { set; get; }
        IntPtr hook {  get; set; }
        GCHandle handle {  get; set; }
        public ScrcpyMonitor(string DeviceName)
        {
             this.DeviceName  = DeviceName;
        }

        public  void Start()
        {
            if (Device.ScrcpyProcess == null)
            {
                return;
            }
            WinEventDelegate myDelegate = WinEventProc;
            handle = GCHandle.Alloc(myDelegate);
            hook =  SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_OBJECT_LOCATIONCHANGE,
                IntPtr.Zero,(WinEventDelegate)handle.Target, (uint)Device.ScrcpyProcess.Id, 0, WINEVENT_OUTOFCONTEXT);

            if (hook == IntPtr.Zero)
            {
                LogHelper.Error($"Failed to set WinEventHook. Error: {Marshal.GetLastWin32Error()}");
                return;
            } 
        }
         

        public  void Stop()
        {
            if (hook != IntPtr.Zero)
            {
                UnhookWinEvent(hook);
                
            }
            if (handle.IsAllocated)
                handle.Free();

        }

        public  void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            uint processId;
            var a= Device.Name;
            GetWindowThreadProcessId(hwnd, out processId);
            if (processId == 0)
                return; // Not the target process's window 
            RECT fx = new RECT();
            switch (eventType)
            {
                case EVENT_SYSTEM_FOREGROUND:
                    fx = new RECT();
                    GetWindowRect(hwnd, ref fx);//h为窗口句柄 
                    main.SetControl(fx);
                    main.ShowControl(Device);
                    Console.WriteLine(a + $"Target window was activated.type: {eventType} time:" + DateTime.Now);
                    break;
                case EVENT_OBJECT_LOCATIONCHANGE: 
                    fx = new RECT();
                    GetWindowRect(hwnd, ref fx);//h为窗口句柄 
                    main.SetControl(fx); 
                    Console.WriteLine(a + $"Target window was moved.type: {eventType} time:" + DateTime.Now);
                    break;
                default:
                    Console.WriteLine($"{a} Unknown event type: {eventType}   time:" + DateTime.Now);
                    break;
            }
        }
    }
}
