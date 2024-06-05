using MobileControlGuru.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MobileControlGuru.Tools;
namespace MobileControlGuru.AutoTask
{
    public class TaskRun
    {
        TaskJson.TaskInfo taskInfo;


        public delegate void TaskStartDelegate();
        public delegate void TaskFinishedDelegate();
        public delegate void TaskSingleEndDelegate();


        public TaskStartDelegate taskstartdelegate;
        public TaskFinishedDelegate taskfinisheddelegate;
        public TaskSingleEndDelegate tasksingleenddelegate;
         

        public TaskRun(TaskJson.TaskInfo taskInfo)
        {
            this.taskInfo = taskInfo;
        }

        public string R(TaskJson.TaskItem taskItem)
        {
            try
            {
                if (taskItem.IsAdb)
                {
                    var adb= ADB.Exec("-s 192.168.191.2:38773" +" "+taskItem.Oprate + " " + taskItem.Param);

                     return adb.Message;
                }
                else
                {
                    if (taskItem.Oprate == "sleep")
                    {
                        Thread.Sleep(Convert.ToInt32(taskItem.Param));
                    }
                    else
                    {
                        var cmd=  CMD.Exec(taskItem.Param);
                        return cmd;
                    }

                }
                return "";
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, taskItem.Oprate+""+ taskItem.Param);
                return ex.Message;
            }
           

        }

        public  void Run()
        {
            foreach(var t in taskInfo.TaskItems)
            {
                R(t);
            }


        }

        public  async Task RunAsync()
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    string website = "https://www.example.com";
            //    string content = await client.GetStringAsync(website);
            //    Console.WriteLine("下载内容长度：" + content.Length);
            //}
        } 
    }
}
