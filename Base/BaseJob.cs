using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class BaseJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            JobKey key = context.JobDetail.Key; 
            JobDataMap dataMap = context.JobDetail.JobDataMap; 
            string jobSays = "";
            dataMap.TryGetString("jobSays", out jobSays);

            return Task.Factory.StartNew(() =>
            {
               
                Console.WriteLine(jobSays + " -- " + DateTime.Now.ToString());

            });
        }
    }
}
