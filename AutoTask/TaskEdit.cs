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
                this.label2.Text = taskInfo.Name;



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
            GetTaksInfo();
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
                return taskInfo;
            }
            else
            {
                return new TaskJson.TaskInfo() {
                    Name = "",
                    TaskItems = list
                };
            }
            
        }

      
        public void ItemDelete(int index)
        {
            UpdateItemIndex();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaskRun tr=new TaskRun(GetTaksInfo());
            tr.Run();
        }
    }
}
