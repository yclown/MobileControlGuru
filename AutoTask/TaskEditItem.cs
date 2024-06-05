using AntdUI;
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
    public partial class TaskEditItem : UserControl
    {

        public delegate void Delete(int index);
        public int Index;
        public Delete deleteEevnt {  get; set; }

        public TaskJson.TaskItem taskItem;
        public TaskEditItem()
        {
            InitializeComponent();
        }
        public TaskEditItem(TaskJson.TaskItem taskItem)
        {
            this.taskItem = taskItem;
            InitializeComponent();
           
        }
        public void SetIndex(int index)
        {
            Index=index;
            this.label1.Text ="操作："+ index.ToString();
        }

        public TaskJson.TaskItem GetTaskInfo()
        {
            return new TaskJson.TaskItem()
            {
                Oprate = ((TaskJson.OpType)this.select1.SelectedValue).Oprate,
                Param = input1.Text,
                IsAdb = ((TaskJson.OpType)this.select1.SelectedValue).IsAdb,
            };
            
        }

        public bool CheckValue()
        {

            return false;
        }

        private void TaskEditItem_Load(object sender, EventArgs e)
        {
            this.select1.Items = TaskJson.Configs;
            this.select1.SelectedIndex = 0;

            if (taskItem != null)
            {
                //this.label1.Text = "操作：" + Index;
                var d= TaskJson.OpTypes.Where(n => n.Oprate == taskItem.Oprate).FirstOrDefault();
                int i= TaskJson.OpTypes.IndexOf(d);
                if(i != -1)
                {
                    this.select1.SelectedIndex = i; 
                } 
                this.input1.Text = taskItem.Param;
            }
            
        }

        private void select1_SelectedIndexChanged(object sender, int value)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Dispose();
            deleteEevnt(Index);
        }
    }
}
