using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    /// <summary>
    /// adb 返回处理
    /// </summary>
    public class AdbParse
    {
        public bool IsSuccess {  get; set; }
        public string Message { set; get; }
        public string Cmd { set; get; }

        public AdbParse(string Cmd, string adbres)
        {
            this.Message= adbres;
            this.Cmd = Cmd;
            this.IsSuccess = true;
            

        }

        public AdbParse(string Cmd, bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
