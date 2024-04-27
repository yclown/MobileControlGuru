using MobileControlGuru.Src;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class ADB
    {

        public static string ADB_PATH = Path.Combine(ConfigHelp.GetConfig("ScrcpyPath"), "adb.exe");
 
        public static AdbParse Exec(string Arguments)
        {
            try
            {
               
                var p = Process.Start(new System.Diagnostics.ProcessStartInfo(ADB_PATH)
                {
                    Arguments = Arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8,
                });
                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                LogHelper.Info("adb exc" + Arguments+"\n"+output);
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
                //p.Dispose();
                return new AdbParse(output);
            }
            catch(Exception e)
            {
                return new AdbParse(false,e.Message);

            }

           

        }

        public async Task ExecuteCommandsInParallel(List<string> commands)
        {
            var tasks = new List<Task>();

            foreach (var command in commands)
            {
                // 创建并启动一个新的任务，传入当前命令
                tasks.Add(Task.Run(() => Exec(command)));
            }

            // 等待所有任务完成
            await Task.WhenAll(tasks);
        }




        #region adb 操作

        public static AdbParse Connect(string device)
        {

            var res = Exec($"connect {device}");
            DeviceManager.Instance.UpdateDevices();
            return res;
        }
        public static AdbParse SendKeyEvent(string device, ADBKey.Key key)
        {

            var res = Exec($"-s {device} shell input keyevent {key}");
            return res;
        }
        public static AdbParse SendKeyEvent(string device, string key)
        {

            var res = Exec($"-s {device} shell input keyevent {key}");
            return res;

        }
        public static AdbParse Screencap(string device, string path)
        {

            var res = Exec($"-s {device} shell screencap -p >{path}");
            return res;

        }

        #endregion
        public static List<Model.Device> GetDeiveces()
        {
            var str = Exec("devices");
            var devices = str.Message.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).Select(line => line.Split('\t')).ToArray();
            List<Model.Device> items = new List<Model.Device>();
            foreach (var deviceInfo in devices)
            {
                if (deviceInfo.Length == 2)
                {
                    string deviceId = deviceInfo[0];
                    string deviceStatus = deviceInfo[1];
                    items.Add(new Model.Device()
                    {
                        Name = deviceId,
                        Status = deviceStatus,
                    });
                }
            }
            items= items.Where(n=>n.Status=="device").ToList();
            return items;
        }

        public static async Task Lock(List<Model.DeviceItem> deviceItems)
        {


            var tasks = new List<Task>();
            foreach (var d in deviceItems)
            {
                // 创建并启动一个新的任务，传入当前命令
                tasks.Add(Task.Run(
                        () =>new DeviceADB(d.Name).SendKeyEvent( ADBKey.Key.KEYCODE_POWER)
                    )
                   );
            }

            // 等待所有任务完成
            await Task.WhenAll(tasks);

        }

        public static void Lock(string device)
        {
            new DeviceADB(device).SendKeyEvent(ADBKey.Key.KEYCODE_POWER);
        }
    }
}
