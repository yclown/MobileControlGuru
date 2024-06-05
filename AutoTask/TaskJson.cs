using MobileControlGuru.Src;
using MobileControlGuru.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileControlGuru.AutoTask
{
    public class TaskJson
    {
        public class OpType
        {
            public string Name { set; get; }
            public string Oprate { set; get; }
            public bool IsAdb { set; get; }

            public override string ToString()
            {
                return Name;
            }

            public OpType(string name, string oprate,bool isAdb=true)
            {
                Name = name;
                Oprate = oprate;
                IsAdb = isAdb;
            }
        }

        public static AntdUI.BaseCollection Configs = new AntdUI.BaseCollection { 
           new OpType("点击","shell input keyevent"),
           new OpType("滑动","shell input swipe"),
           new OpType("按键","shell input keyevent"),
           new OpType("启动APP","shell am start -n"),
           new OpType("睡眠","sleep",false),
           new OpType("自定义命令","custom",false),
        };


        
        public class TaskItem
        {
             
            public string Oprate;
            public string Param;
            public bool IsAdb;

            
        }
        public class TaskInfo
        {

            public string Name;
            public List<TaskItem> TaskItems;
            
            //public string Name;
        }


        public List<TaskInfo> tasks { set; get; }

        private static TaskJson instance = null;
        private static readonly object lockObj = new object();
        private TaskJson() { }
        /// <summary>
        /// 单例模式
        /// </summary>
        public static TaskJson Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new TaskJson();
                            instance.tasks = new List<TaskInfo>();
                        }
                    }
                }
                return instance;
            }
        }




        public static void LoadJsonData()
        {
            try
            {
                // 获取程序基目录  
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                // 构建JSON文件的完整路径  
                string jsonFilePath = Path.Combine(basePath, "task.json"); // 假设你的JSON文件名为data.json  
                if(!File.Exists(jsonFilePath))
                {
                    File.Create(jsonFilePath);
                    instance.tasks=new List<TaskInfo>();
                    return;
                }
                // 读取JSON文件内容  
                string jsonString = File.ReadAllText(jsonFilePath);
                 
                instance.tasks = JsonConvert.DeserializeObject<List<TaskInfo>>(jsonString); 
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, "load json data");
                // 处理异常，例如文件不存在、JSON格式错误等  
                //MessageBox.Show("Error loading JSON data: " + ex.Message);
            }
        }
        public static void SaveJsonData()
        {
            try
            {
                // 获取程序基目录  
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                // 构建JSON文件的完整路径  
                string jsonFilePath = Path.Combine(basePath, "task.json"); // 假设你的JSON文件名为data.json  
                if (!File.Exists(jsonFilePath))
                {
                    File.Create(jsonFilePath);
                } 
                string jsonString = JsonConvert.SerializeObject(instance.tasks, Formatting.Indented); 
                // 将JSON字符串写回到文件  
                File.WriteAllText(jsonFilePath, jsonString); 
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex,"save json data");
                // 处理异常，例如文件不存在、JSON格式错误等  
                //MessageBox.Show("Error loading JSON data: " + ex.Message);
            }
        }

    }
}
