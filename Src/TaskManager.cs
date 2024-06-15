using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Src
{
    /// <summary>
    /// 任务管理
    /// </summary>
    public class TaskManager
    {
        private static TaskManager instance = null;
        private static readonly object lockObj = new object();
        private TaskManager() {


            factory = new StdSchedulerFactory();

        }
        /// <summary>
        /// 单例模式
        /// </summary>
        public static TaskManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new TaskManager(); 
                        }
                    }
                }
                return instance;
            }
        }

        StdSchedulerFactory factory ;
        IScheduler scheduler;


        public async void Start()
        {
          
            scheduler= await factory.GetScheduler();
            await scheduler.Start();
        }
    }
}
