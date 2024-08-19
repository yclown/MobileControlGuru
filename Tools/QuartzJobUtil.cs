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
        public static ISchedulerFactory schedulerFactory = SchedulerBuilder.Create()
            .WithMisfireThreshold(TimeSpan.FromMilliseconds(1000))
            .WithId("")
            .WithName("")
            .WithMaxBatchSize(2)
            .WithInterruptJobsOnShutdown(true)
            .WithInterruptJobsOnShutdownWithWait(true)
            .WithBatchTriggerAcquisitionFireAheadTimeWindow(TimeSpan.FromMilliseconds(1))
            .Build();
        public static IScheduler _scheduler ;

        public static IScheduler scheduler { 
            get 
            {
                if (_scheduler == null)
                {
                    _scheduler = schedulerFactory.GetScheduler().Result;
                }

                return _scheduler; 
            }
        
        }

        //public static IScheduler
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
        public static void ShutdownScheduler(bool waitForJobsToComplete=false)
        {

            try
            {
                scheduler.Shutdown(waitForJobsToComplete);
                _scheduler = null;
            }
            catch (SchedulerException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 挂起
        /// </summary>
        public static void StandbyScheduler()
        {

            try
            {
                scheduler.Standby();
               
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
        /// <param name="cronExpression"></param>
        public static void AddJob<T>(String jobName, string cronExpression, JobDataMap newJobDataMap, String jobGroupName = "default") where T : IJob
        {
            //创建任务
            IJobDetail jobDetail = JobBuilder.Create<T>()
                .WithIdentity(jobName, jobGroupName)
                .UsingJobData(newJobDataMap)
                .Build();
            var trigger = TriggerBuilder.Create()
                      .WithIdentity(jobName, jobGroupName)
                     .ForJob(jobName, jobGroupName)
                     .WithCronSchedule(cronExpression, n =>
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

        public static void AddTaskJob<T>(String jobName, AutoTask.TaskJson.TaskInfo taskInfo, String jobGroupName = "default") where T : IJob
        {
            var data = new JobDataMap(new Dictionary<string, AutoTask.TaskJson.TaskInfo>
                    {
                         {"taskInfo", taskInfo }
                    });
            //创建任务
            IJobDetail jobDetail = JobBuilder.Create<T>()
                .WithIdentity(jobName, jobGroupName)
                .UsingJobData(data)
                .Build();
            var trigger = TriggerBuilder.Create()
                      .WithIdentity(jobName, jobGroupName)
                     .ForJob(jobName, jobGroupName)
                     .WithCronSchedule(taskInfo.Corn, n =>
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
        /// 更新任务
        /// </summary>
        /// <param name="jobName"></param> 
        /// <param name="taskInfo"></param>
        public static void UpdateTask(String jobName, AutoTask.TaskJson.TaskInfo taskInfo)
        {
            try
            {
                TriggerKey triggerKey = new TriggerKey(jobName);
                var job = GetJob(jobName); 
                scheduler.PauseTrigger(triggerKey);// 停止触发器
                scheduler.UnscheduleJob(triggerKey);// 移除触发器  
                scheduler.DeleteJob(job.Key);
                AddTaskJob<AutoTask.BaseJob>(jobName, taskInfo);
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
                    .WithCronSchedule(cornExp)
                    .Build();
                scheduler.ScheduleJob(job, newTrigger);
                //scheduler.ScheduleJob(newTrigger);
            }
            catch (SchedulerException e)
            {

                throw e;
            }
        }

      
        public static DateTime? GetNextTime(string cornexp,DateTime? dateTime)
        {
            if (string.IsNullOrEmpty(cornexp)|| dateTime==null)
            {
                return null;
            }
            try
            {
                CronExpression cronExpression = new CronExpression(cornexp); 
                var datetime = cronExpression.GetNextValidTimeAfter((DateTime)dateTime)?.ToLocalTime().DateTime;
                return datetime;
            }
            catch(Exception ex)
            {
                LogHelper.Error(ex, "根据corn表达式获取下个运行时间出错");
                return null;
            }
           
        }
    }
}
