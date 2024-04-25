using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MobileControlGuru.WebAPI.Controllers
{

    
    public class HomeController : ApiController
    {

       
        public string Index() {

            return "opened";
        }
    }
}
