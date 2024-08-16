using MobileControlGuru.Src;
using MobileControlGuru.Tools;
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

namespace MobileControlGuru.AutoTask
{
    public partial class TaskShowItem : UserControl
    {
        public TaskShowItem()
        {
            InitializeComponent();
        }
        public TaskJson.TaskInfo taskInfo;
        public TaskList taskList;
        TaskRunWindow runWindow;
        
        public TaskShowItem(TaskJson.TaskInfo taskInfo)
        {
            this.taskInfo = taskInfo;
            InitializeComponent();
        }

        private void TaskShowItem_Load(object sender, EventArgs e)
        {
            if (taskInfo != null)
            {
                this.label1.Text = taskInfo.Name;
                this.inputNumber1.Value=taskInfo.RunTimes;
               
                run_able.Text = taskInfo.IsRun?"启用中":"禁用中";
                run_able.Type = taskInfo.IsRun ? AntdUI.TTypeMini.Success: AntdUI.TTypeMini.Warn;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var taskinfo= (TaskJson.TaskInfo)this.Tag;

            taskList.ShowEdit(taskinfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var taskinfo = (TaskJson.TaskInfo)this.Tag;
            DialogResult AF = MessageBox.Show("确定删除"+ taskinfo.Name+ "任务吗？", "确认框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (AF == DialogResult.OK)
            {
                taskList.DelTask(taskinfo.id);
            } 
            else
            {
                
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //AntdUI.Button button = (AntdUI.Button)sender;

            //DeviceManager.Instance.devices.ForEach(n =>
            //{
                 

            //}); 
            runWindow = new TaskRunWindow(taskInfo);
            runWindow.Show();
            //button.Visible = false;
            //runWindow.taskStartDelegate += taskStart;
            //runWindow.taskFinishedDelegate += taskFinished; 
            runWindow.RunTask();
        }

        private void taskStart()
        {
            UpdateButton(run, false);
            UpdateButton(del, false);
            UpdateButton(edit, false);

            UpdateButton(button4, true);
            UpdateButton(run_able, true);
        }

        private void taskFinished()
        {
            UpdateButton(run,true);
            UpdateButton(del,true);
            UpdateButton(edit,true);

            UpdateButton(button4,false);
            UpdateButton(run_able, false);
           
            runWindow=null;
        }

        private void UpdateButton(AntdUI.Button button, bool visible)
        {
            if (button.InvokeRequired)
            {
                button.Invoke(new Action(() =>
                {
                    button.Visible = visible;

                }));
            }
            else
            {
                button.Visible = visible;
            }
        }

        private void inputNumber1_ValueChanged(object sender, decimal value)
        {
            taskInfo.RunTimes=Convert.ToInt32(value);
            TaskJson.EditTask(taskInfo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            runWindow.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //runWindow.taskRun.cts.Cancel();

            var btn = (AntdUI.Button)sender;
            this.taskInfo.IsRun = !taskInfo.IsRun;

            if (taskInfo.IsRun)
            {
                btn.Text = "启用中";
                btn.Type = AntdUI.TTypeMini.Success;

                QuartzJobUtil.ResumeJob(taskInfo.id.ToString());
            }
            else
            {
                btn.Text = "禁用中";
                btn.Type = AntdUI.TTypeMini.Warn;
                QuartzJobUtil.PauseJob(taskInfo.id.ToString());
            }
            TaskJson.EditTask(taskInfo);
        }
    }
}
