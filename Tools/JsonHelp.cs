using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace MobileControlGuru.Tools
{
    public class JsonHelp
    {

        public static T Str2Obj<T>(string input)
        {
            return new JavaScriptSerializer().Deserialize<T>(input);
        }
         
        public static string Obj2Str(object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}
