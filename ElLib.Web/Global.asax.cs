using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.Web.Security;
using ElLib.BLL.Authentication;
using ElLib.Common.Entities;
using ElLib.Common.Logger;
using ElLib.Web.App_Start;
using ElLib.Web.DependencyResolution;
using StructureMap;

namespace ElLib.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
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

            ILogger logger = container.GetInstance<ILogger>();

            logger.Error(exception.Message);
        }
    }
}
