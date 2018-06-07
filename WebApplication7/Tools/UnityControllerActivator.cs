using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Unity;

namespace WebApplication7.Tools
{
    public class UnityControllerActivator : IHttpControllerActivator
    {
        private readonly IUnityContainer _container;
        public UnityControllerActivator(UnityContainer container)
        {
            _container = container;
        }
        public IHttpController Create(HttpRequestMessage request,
            HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var rest = (IHttpController)_container.Resolve(controllerType);
            return rest;
        }
    }
}