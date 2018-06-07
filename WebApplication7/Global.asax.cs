using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Security;
using System.Web.SessionState;
using Unity;
using WebApis;
using WebApplication7.Tools;
using Unity.Lifetime;
namespace WebApplication7
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new UnityContainer();
            container.RegisterType<PersonController>(new TransientLifetimeManager());

            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                new UnityControllerActivator(container));

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}