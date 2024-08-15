using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using static MobileControlGuru.AutoTask.TaskRun;

namespace MobileControlGuru.AutoTask
{
    public partial class TaskRunWindow : BaseForm
    {
        public string DeviceName;
        public TaskJson.TaskInfo TaskInfo;
        public TaskRun taskRun;
        bool Debug=false;
        public System.Threading.Tasks.Task task;
      
        //任务开始委托
        public TaskStartDelegate taskStartDelegate;
        //任务结束委托
        public TaskFinishedDelegate taskFinishedDelegate;

        //单条指令开始
        public TaskSingleStartDelegate singleStartDelegate;
        //单条指令结束 
        public TaskSingleEndDelegate singleEndDelegate;

        public TaskRunWindow( TaskJson.TaskInfo taskInfo, bool debug=false)
        {
            DeviceName = taskInfo.DeviceName;
            TaskInfo = taskInfo;
            Debug = debug;
            InitializeComponent();
           
        }

        public void RunTask()
        {
            taskRun = new TaskRun(DeviceName, TaskInfo, Debug);
            taskRun.singleStartDelegate += TaskItemStart;
            taskRun.singleEndDelegate += TaskItemEnd;
            taskRun.taskStartDelegate += TaskStart;
            taskRun.taskFinishedDelegate += TaskFinished;

            taskRun.taskStartDelegate += taskStartDelegate;
            taskRun.taskFinishedDelegate += taskFinishedDelegate;
            taskRun.singleStartDelegate += singleStartDelegate;
            taskRun.singleEndDelegate += singleEndDelegate;
          
            task = new System.Threading.Tasks.Task(() =>
            {
                
                taskRun.Run();
                
            }, taskRun.cts.Token);
            task.Start();
           
        }

        private void TaskStart()
        {
           
            UpdateButtonStart(false);
            UpdateButtonEnd(true);
            AddMessage("task Start :"+DateTime.Now.ToString());
        }

        private void TaskFinished()
        {
            UpdateButtonStart(true);
            UpdateButtonEnd( false);
            AddMessage("task End :"+ DateTime.Now.ToString());
        }
        private void UpdateButtonStart(bool visible)
        {
            if (button1.InvokeRequired)
            {
                button1.Invoke(new Action(() =>
                {
                    this.button1.Visible = visible; 
                    
                }));
            }
            else
            {
                this.button1.Visible = visible;
            }
        }

        private void UpdateButtonEnd(bool visible)
        {
            if (button2.InvokeRequired)
            {
                button2.Invoke(new Action(() =>
                {
                    this.button2.Visible = visible;

                }));
            }
            else
            {
                this.button2.Visible = visible;
            }
        }

        private void TaskItemEnd(string output)
        {
            AddMessage("output："+output);
          
        }

        private void TaskItemStart(string cmd)
        {
            AddMessage("cmd：" + cmd);
           // throw new NotImplementedException();
        }

        public void AddMessage(string msg)
        {
            
            // 假设这是你在后台线程中执行的代码  
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action(() =>
                {
                    this.textBox1.Text += msg + Environment.NewLine;
                    this.textBox1.Refresh();
                    textBox1.SelectionStart = textBox1.Text.Length; // 设置选区开始位置为文本末尾  
                    textBox1.ScrollToCaret(); // 滚动到插入符号位置（即文本末尾）
                }));
            }
            else
            {
                // 如果当前线程已经是UI线程，则直接更新  
                this.textBox1.Text += msg + Environment.NewLine;
                this.textBox1.Refresh();
                textBox1.SelectionStart = textBox1.Text.Length; // 设置选区开始位置为文本末尾  
                textBox1.ScrollToCaret(); // 滚动到插入符号位置（即文本末尾）
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunTask();
        }

        private void TaskRunWindow_Load(object sender, EventArgs e)
        {

        }

        private void TaskRunWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //task.ki();
            taskRun.cts.Cancel();
            //TaskFinished();
        }



    }
}
