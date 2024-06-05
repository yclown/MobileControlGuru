using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class CMD
    {

        public static string Exec(string command) {

            LogHelper.Info("cmd run:" + command);
            // 创建一个新的ProcessStartInfo对象来配置进程启动信息  
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe"; // 指定要运行的命令解释器（CMD）  
            startInfo.Arguments = "/C " + command; // 指定要运行的命令和参数（/C 表示执行完命令后关闭命令窗口）  
            startInfo.RedirectStandardOutput = true; // 重定向标准输出以便捕获输出  
            startInfo.UseShellExecute = false; // 设置为false以便能够重定向输出  
            startInfo.CreateNoWindow = true; // 设置为true以隐藏命令窗口（如果不需要看到窗口）  
            
            // 使用ProcessStartInfo对象启动进程  
            using (Process process = new Process { StartInfo = startInfo })
            {
                // 启动进程  
                process.Start();

                // 读取命令的输出  
                string output = process.StandardOutput.ReadToEnd();

                // 等待进程结束  
                process.WaitForExit();
                LogHelper.Info("cmd output:" + output);
                return output;
            }

           

        }
    }
}
