using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ElLib.Web.DependencyResolution;
using log4net;
using StructureMap;

namespace ElLib.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();

            IContainer container = IoC.Initialize();
            ILog logger = container.GetInstance<ILog>();
            logger.Error(exception.Message);

            HttpException httpException = exception as HttpException;

            if (httpException != null)
            {
                int code = httpException.GetHttpCode();
                if (code == 404)
                {
                    //TODO
                }
            }
        }
    }
}
