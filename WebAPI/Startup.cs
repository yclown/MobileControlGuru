using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Swashbuckle.Application;
using static System.Windows.Forms.Design.AxImporter;
using System.IO;
using System.Reflection;

namespace MobileControlGuru.WebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { 
                    controller = "Home", 
                    action = "Index",
                    id = RouteParameter.Optional 
                }
            );
            config
                .EnableSwagger(c => {
                    c.SingleApiVersion("v1", "mobile control guru api");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); 
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    var commentsFileName = Assembly.GetExecutingAssembly().GetName().Name + ".XML";
                    var commentsFile = Path.Combine(baseDirectory, commentsFileName);
                    c.IncludeXmlComments(commentsFile);
                })
                .EnableSwaggerUi();
            
            //清除xml格式，使用json格式
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

           

            appBuilder.UseWebApi(config);
        }
    }
}
