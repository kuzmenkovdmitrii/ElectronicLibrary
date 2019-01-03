using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.Web.Security;
using ElLib.BLL.Authentication;
using ElLib.Common.Entity;
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

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            HttpCookie authCookie = HttpContext.Current.Request.Cookies.Get(FormsAuthentication.FormsCookieName);

            if (authCookie != null)
            {
                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                User user = serializer.Deserialize<User>(authTicket.UserData);

                UserPrincipal userPrincipal = new UserPrincipal(user);

                HttpContext.Current.User = userPrincipal;
            }
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
