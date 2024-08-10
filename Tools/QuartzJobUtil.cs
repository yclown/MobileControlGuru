using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Tools
{
    public class QuartzJobUtil
    {




        //使用默认的配置
        private static ISchedulerFactory schedulerFactory = SchedulerBuilder.Create()
            .WithMisfireThreshold(TimeSpan.FromMilliseconds(1000))
            .WithId("")
            .WithName("")
            .WithMaxBatchSize(2)
            .WithInterruptJobsOnShutdown(true)
            .WithInterruptJobsOnShutdownWithWait(true)
            .WithBatchTriggerAcquisitionFireAheadTimeWindow(TimeSpan.FromMilliseconds(1))
            .Build();
        private static IScheduler scheduler = schedulerFactory.GetScheduler().Result;


        //获取一个默认的Scheduler对象
        public static void StartScheduler()
        {
            try
            {
                if (scheduler != null)
                {
                    if (!scheduler.IsStarted)
                    {
                        scheduler.Start();

                    }

                }

            }
            catch (SchedulerException e)
            {
                throw e;
            }

        }

        /// <summary>
        ///  shutdown(true)表示等待所有正在执行的任务执行完毕后关闭Scheduler
        ///  shutdown(false),即shutdown()表示直接关闭Scheduler
        /// </summary>
        public static void ShutdownScheduler(bool waitForJobsToComplete)
        {

            try
            {
                scheduler.Shutdown(waitForJobsToComplete);
            }
            catch (SchedulerException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 暂停所有任务执行
        /// </summary>
        public static void PauseAllScheduler()
        {

            try
            {
                scheduler.PauseAll();

            }
            catch (SchedulerException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 添加任务
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jobName"></param>
        /// <param name="jobGroupName"></param>
        /// <param name="newJobDataMap"></param>
        public static void AddJob<T>(String jobName, string cronExpression, JobDataMap newJobDataMap, String jobGroupName = "default") where T : IJob
        {

            //创建任务
            IJobDetail jobDetail = JobBuilder.Create<T>()
                .WithIdentity(jobName, jobGroupName)
                .UsingJobData(newJobDataMap)

                .Build();
            //创建触发器 每 5 秒钟执行一次 
            var trigger = TriggerBuilder.Create()
                      .WithIdentity(jobName, jobGroupName)
                     .ForJob(jobName, jobGroupName)
                     .WithCronSchedule("0/3 * * * * ?", n =>
                     {
                         n.WithMisfireHandlingInstructionDoNothing();
                     })
                     .Build();
            try
            {
                //将任务及其触发器放入调度器
                scheduler.ScheduleJob(jobDetail, trigger);

            }
            catch (SchedulerException e)
            {
                throw e;
            }

        }
        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobGroupName"></param>
        public static void DeleteJob(String jobName, String jobGroupName = "default")
        {
            try
            {
                TriggerKey triggerKey = new TriggerKey(jobName, jobGroupName);

                scheduler.PauseTrigger(triggerKey);// 停止触发器
                scheduler.UnscheduleJob(triggerKey);// 移除触发器
                scheduler.DeleteJob(JobKey.Create(jobName, jobGroupName));
                Console.WriteLine($"删除任务，jobName：{jobName} ,jobGroupName:{jobGroupName}");
            }
            catch (SchedulerException e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 暂停任务
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobGroupName"></param>
        public static void PauseJob(String jobName, String jobGroupName = "default")
        {
            try
            {
                TriggerKey triggerKey = new TriggerKey(jobName, jobGroupName);

                scheduler.PauseTrigger(triggerKey);// 停止触发器 
                scheduler.PauseJob(JobKey.Create(jobName, jobGroupName));
            }
            catch (SchedulerException e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 恢复任务
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobGroupName"></param>
        public static void ResumeJob(String jobName, String jobGroupName = "default")
        {
            try
            { 
                TriggerKey triggerKey = new TriggerKey(jobName, jobGroupName); 
                scheduler.ResumeTrigger(triggerKey); 
                scheduler.ResumeJob(JobKey.Create(jobName, jobGroupName));
            }
            catch (SchedulerException e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 获取任务信息
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobGroupName"></param>
        /// <returns></returns>
        public static IJobDetail GetJob(String jobName, String jobGroupName = "default")
        {
            try
            {
                JobKey triggerKey = new JobKey(jobName, jobGroupName);

                return scheduler.GetJobDetail(triggerKey).Result;
            }
            catch (SchedulerException e)
            {

                return null;
            }
        }

        public static ITrigger GetTrigger(String jobName, String jobGroupName = "default")
        {
            try
            {

                TriggerKey triggerKey = new TriggerKey(jobName, jobGroupName);

                return scheduler.GetTrigger(triggerKey).Result;
            }
            catch (SchedulerException e)
            {

                return null;
            }
        }

        public static void UpdateTrigger(String jobName, string cornExp, String jobGroupName = "default")
        {
            try
            {
                TriggerKey triggerKey = new TriggerKey(jobName, jobGroupName);
                var job = GetJob(jobName, jobGroupName);

                scheduler.PauseTrigger(triggerKey);// 停止触发器
                scheduler.UnscheduleJob(triggerKey);// 移除触发器 

                var newTrigger = TriggerBuilder.Create()
                     .WithIdentity(jobName, jobGroupName)
                    .ForJob(jobName, jobGroupName)
                    .WithCronSchedule("0/1 * * * * ?")
                    .Build();
                scheduler.ScheduleJob(job, newTrigger);
                //scheduler.ScheduleJob(newTrigger);
            }
            catch (SchedulerException e)
            {

                throw e;
            }
        }
    }
}
