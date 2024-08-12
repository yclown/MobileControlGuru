using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.AutoTask
{
    public class BaseJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            JobKey key = context.JobDetail.Key; 
            JobDataMap dataMap = context.JobDetail.JobDataMap; 
            string devicename = dataMap.GetString("devicename");
            TaskJson.TaskInfo taskInfo = (TaskJson.TaskInfo)dataMap.Get("taskInfo");
            
            return Task.Factory.StartNew(() =>
            {
                TaskRun taskRun = new TaskRun(devicename, taskInfo);
                taskRun.Run(); 
            });
        }
    }
}
