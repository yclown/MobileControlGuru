using MobileControlGuru.Tools;
using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MobileControlGuru.AutoTask.TaskJson;

namespace MobileControlGuru.AutoTask
{
    public partial class TaskList : BaseForm
    {
        public TaskList()
        {
            InitializeComponent();
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            TaskJson.LoadJsonData();
            this.flowLayoutPanel1.Controls.Clear();
            foreach (var task in TaskJson.Instance.tasks)
            {
                var item = new TaskShowItem(task);
                item.taskList = this;
                item.Tag = task;
                
                this.flowLayoutPanel1.Controls.Add(item);
            }
            start_quatrz.Visible = !QuartzJobUtil.scheduler.IsStarted;
            shutdown.Visible = QuartzJobUtil.scheduler.IsStarted;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowEdit(null);
        }

        private void EditFormClosed(object sender, FormClosedEventArgs e)
        {
            Init();
        }

        public void ShowEdit(TaskJson.TaskInfo taskinfo)
        {
            TaskEdit diglog = new TaskEdit(taskinfo);
            diglog.StartPosition = FormStartPosition.CenterParent;
            diglog.FormClosed += EditFormClosed;
            diglog.Show(this);
            
        }

        public void DelTask (int id)
        {
           
            TaskJson.DelTask(id);
             Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuartzJobUtil.StartScheduler(); 
            foreach (var task in TaskJson.Instance.tasks)
            {
                
                try
                {
                    Dictionary<string, TaskJson.TaskInfo> a = new Dictionary<string, TaskJson.TaskInfo>
                    {
                         {"taskInfo", task }
                    };
                    QuartzJobUtil.AddJob<BaseJob>
                        (task.id.ToString(), task.Corn, new JobDataMap(a));

                    if (!task.IsRun)
                    {
                        QuartzJobUtil.PauseJob(task.id.ToString());
                    }

                }
                catch (Exception ex) {
                    LogHelper.Error(ex);
                    MessageBox.Show($"添加任务{task.Name}出错 任务id:{task.id}");
                }

              

            }

            start_quatrz.Visible = false;
            shutdown.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuartzJobUtil.ShutdownScheduler();
            start_quatrz.Visible = true;
            shutdown.Visible = false;
        }
    }
}
