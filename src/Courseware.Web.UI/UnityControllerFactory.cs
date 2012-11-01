using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace Courseware.Web.UI
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly UnityContainer _container;

        public UnityControllerFactory(UnityContainer container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)_container.Resolve(controllerType);
        }

    }
}