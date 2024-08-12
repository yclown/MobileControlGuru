using Microsoft.VisualBasic;
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

            if (taskInfo != null)
            {
                this.input1.Text = taskInfo.Name;

                foreach(var item in taskInfo.TaskItems)
                {
                    var edit = new TaskEditItem(item);
                    edit.deleteEevnt += ItemDelete;
                    this.flowLayoutPanel1.Controls.Add(edit);
                }

            }

        }

        private void Init()
        {



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
                taskInfo.Name=this.input1.Text;
                taskInfo.DeviceName = this.input3.Text;
                return taskInfo;
            }
            else
            { 
                return new TaskJson.TaskInfo() {
                    Name = this.input1.Text,
                    TaskItems = list,
                    DeviceName=input3.Text
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
           
            selectDevice = new SelectDevice();
            selectDevice.button1.Click += SureDevice;
            selectDevice.ShowDialog(this);  
            //tr.Run();


        } 
        private void SureDevice(object sender, EventArgs e)
        {
            var name= this.selectDevice.select1.SelectedValue.ToString();
            selectDevice.Dispose();
            TaskRunWindow tr = new TaskRunWindow(name,GetTaksInfo(),true);
            tr.Text = "debug on:"+name;
            tr.ShowDialog(this);
        }

        private void select1_SelectedIndexChanged(object sender, int value)
        {

        }
    }
}
