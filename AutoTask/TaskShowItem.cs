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
    public partial class TaskShowItem : UserControl
    {
        public TaskShowItem()
        {
            InitializeComponent();
        }
        public TaskJson.TaskInfo taskInfo;
        public TaskList taskList;
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
    }
}
