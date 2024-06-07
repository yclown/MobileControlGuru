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
    public partial class TaskRunWindow : BaseForm
    {
        public string DeviceName;
        public TaskJson.TaskInfo TaskInfo;
        TaskRun taskRun;
        bool Debug=false;
        public TaskRunWindow(string deviceName, TaskJson.TaskInfo taskInfo, bool debug=false)
        {
            DeviceName = deviceName;
            TaskInfo = taskInfo;
            Debug = debug;
            InitializeComponent();
           
        }

        public void RunTask()
        {
            taskRun = new TaskRun(DeviceName, TaskInfo, Debug);
            taskRun.singleStartDelegate += TaskItemStart;
            taskRun.singleEndDelegate += TaskItemEnd; 
            taskRun.Run();
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
            this.textBox1.Text += msg + Environment.NewLine;
            this.textBox1.Refresh();
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
    }
}
