using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class ScrcpyParamAttribute : Attribute
    {
        public string ParamName { get; set; }
        public string ValueSymbol { get; set; }

        public ScrcpyParamAttribute(string paramName, string valueSymbol="=")
        {
            ParamName = paramName;
            ValueSymbol = valueSymbol;
        }
    }
}
