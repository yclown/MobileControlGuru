using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class Scrcpy
    {
        public static string PATH = Path.Combine(ConfigHelp.GetConfig("ScrcpyPath"), "scrcpy.exe"); 
        
        public static bool ChcekScrcpyPATH()
        {

            return File.Exists(PATH);
        }
        public static void ExtractScrcpyZip(string BasePath)
        {

            ZipHelper.ExtractZipToDirectory(BasePath);
            string basapath = Path.Combine(BasePath, "scrcpy-win64-v2.4");
            Tools.ConfigHelp.SetSetting("ScrcpyPath", basapath);
            ADB.ADB_PATH = Path.Combine(basapath, "adb.exe");
            Scrcpy.PATH = Path.Combine(basapath, "scrcpy.exe");
        }

        public static Process Exec(string Arguments)
        {
            LogHelper.Info("exc [scrcpy " + Arguments+"]");
            var p = Process.Start(new System.Diagnostics.ProcessStartInfo(PATH)
            {
                Arguments = Arguments,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8,
            }); 
            p.EnableRaisingEvents = true; 
            return p;
        }

        #region
        public static Process IPConnet(string device,string port)
        { 
            string device_ip = $"{device}:{port}"; 
            var p= IPPut(device_ip);
            return p;
        }
        public static Process IPPut(string device_ip)
        {
            var adbinfo = ADB.Connect(device_ip); 
            var p = Exec($"-s {device_ip} --window-title={device_ip} "+Scrcpy.GetDefaultSetting());
            return p;
        }


        public static Process UsbPut(string device)
        { 
            var p = Exec($"  -s {device} --window-title={device} " + Scrcpy.GetDefaultSetting());
            return p;
        }

        public static Process Put(string device,string CustomSetting="")
        {
            Process p = null;
            if (string.IsNullOrEmpty(CustomSetting))
            {
                p = Exec($"  -s {device} --window-title={device} " + CustomSetting);
            }
            else
            {
                p = Exec($"  -s {device} --window-title={device} " + Scrcpy.GetDefaultSetting());
            }
            
            return p;
        }
        #endregion


        public static string GetDefaultSetting()
        {
            var scrcpyParam = JsonHelp.Str2Obj<ScrcpyParam>(ConfigHelp.GetConfig("ScrcpyParamObj"));

            if (scrcpyParam != null)
            {
                return scrcpyParam.ToString();
            }

            return "";
        }
    }
}
