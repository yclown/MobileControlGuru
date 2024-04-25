using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileControlGuru.Tools
{
    public class Common
    {
        public static bool IsValidIP(string input)
        {
            // 匹配IP地址，后面可选地跟一个冒号和1-65535之间的端口号
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(:[1-9][0-9]{1,4})?$";

            return Regex.IsMatch(input, pattern);
        }
    }
}
