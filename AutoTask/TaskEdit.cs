using Microsoft.VisualBasic;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru.AutoTask
{
    public partial class TaskEdit : BaseForm
    {

        public TaskJson.TaskInfo taskInfo;

        public TaskEdit()
        {
            InitializeComponent();
        }

        public TaskEdit(TaskJson.TaskInfo taskInfo)
        {
            this.taskInfo = taskInfo;
            InitializeComponent();
        }
        private void TaskEdit_Load(object sender, EventArgs e)
        {
            Init(); 
        }

        private void Init()
        {

            if (taskInfo != null)
            {
                this.task_name.Text = taskInfo.Name;
                this.devicename_input.Text = taskInfo.DeviceName;
                this.cornexp_input.Text = taskInfo.Corn;

                foreach (var item in taskInfo.TaskItems)
                {
                    var edit = new TaskEditItem(item);
                    edit.deleteEevnt += ItemDelete;
                    this.flowLayoutPanel1.Controls.Add(edit);
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var edit = new TaskEditItem();
            edit.deleteEevnt += ItemDelete;
           
            this.flowLayoutPanel1.Controls.Add(edit);
            UpdateItemIndex();
        }
        private void UpdateItemIndex()
        {
            int i = 0;
            foreach (TaskEditItem c in this.flowLayoutPanel1.Controls)
            {
                c.SetIndex(++i);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var t= GetTaksInfo();
            if(t.id == 0)
            {
                TaskJson.AddTask(t); 
            }
            else
            {
                TaskJson.EditTask(t);
            }
            this.Close();

        }


        public TaskJson.TaskInfo GetTaksInfo()
        {
            List<TaskJson.TaskItem> list = new List<TaskJson.TaskItem>();

            foreach (TaskEditItem c in this.flowLayoutPanel1.Controls)
            {
                list.Add(c.GetTaskInfo());
            }

            if(taskInfo != null)
            {
                taskInfo.TaskItems=list;
                taskInfo.Name=this.task_name.Text;
                taskInfo.DeviceName = this.devicename_input.Text;
                taskInfo.Corn = this.cornexp_input.Text;
                return taskInfo;
            }
            else
            { 
                return new TaskJson.TaskInfo() {
                    Name = task_name.Text,
                    TaskItems = list,
                    DeviceName=devicename_input.Text,
                    Corn = cornexp_input.Text
            };
            }
            
        }

      
        public void ItemDelete(int index)
        {
            UpdateItemIndex();
        }


        SelectDevice selectDevice;
        private void button4_Click(object sender, EventArgs e)
        {
            var taskinfo = GetTaksInfo();
            TaskRunWindow tr = new TaskRunWindow(taskinfo, true);
            tr.Text = "debug on:" + taskinfo.DeviceName;
            tr.ShowDialog(this);


            //selectDevice = new SelectDevice();
            //selectDevice.button1.Click += SureDevice;
            //selectDevice.ShowDialog(this);  
            //tr.Run();


        } 
        private void SureDevice(object sender, EventArgs e)
        {
            var name= this.selectDevice.select1.SelectedValue.ToString();
            selectDevice.Dispose();
            TaskRunWindow tr = new TaskRunWindow(GetTaksInfo(),true);
            tr.Text = "debug on:"+name;
            tr.ShowDialog(this);
        }

        private void select1_SelectedIndexChanged(object sender, int value)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var time= QuartzJobUtil.GetNextTime(this.cornexp_input.Text, DateTime.Now);

            List<string> five_runtime = new List<string>();
            DateTime? lastTime = DateTime.Now;
            for (int i = 0; i < 5; i++)
            {
                var time = QuartzJobUtil.GetNextTime(this.cornexp_input.Text, lastTime);
                
                if (time != null)
                {
                    five_runtime.Add(((DateTime)time).ToString("yyyy-MM-dd HH:mm:ss"));
                }
                lastTime = time;
            }
            MessageBox.Show(string.Join("\n", five_runtime),"最近5次运行时间");
        }
    }
}
