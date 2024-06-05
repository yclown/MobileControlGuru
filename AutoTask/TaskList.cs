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
            diglog.ShowDialog(this);
            
        }

        public void DelTask (int id)
        {
           
            TaskJson.DelTask(id);
             Init();
        }
    }
}
