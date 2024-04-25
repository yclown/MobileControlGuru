using Microsoft.Owin.Hosting;
using MobileControlGuru.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MobileControlGuru.WebAPI
{
    public class WebHelper
    {
        public string Port { set; get; }
        public bool Runnig { set; get; }
        IDisposable myOwinServer;

        public string Url { set; get; }

        public WebHelper(string port)
        {
            if (string.IsNullOrEmpty(port))
            {
                Port = port;
            }else
            if (string.IsNullOrEmpty(ConfigHelp.GetConfig("WebPort")))
            {
                Port = ConfigHelp.GetConfig("WebPort");
            }
            else
            {
                Port = "12345";
            }   
        }

        public WebHelper()
        {
            if (string.IsNullOrEmpty(ConfigHelp.GetConfig("WebPort")))
            {
                Port = ConfigHelp.GetConfig("WebPort");
            }
            else
            {
                Port = "12345";
            }
        }

        public void Run()
        {
            int port = Convert.ToInt32(Port);
            StartOptions options = new StartOptions(); 
            Url = "http://localhost:" + port;
            options.Urls.Add("http://+:" + port);
            myOwinServer = WebApp.Start<Startup>(options); 
           

        }
        public void Dispose()
        {
            
            myOwinServer?.Dispose();
            Runnig = false;
        }

        

    }
}
