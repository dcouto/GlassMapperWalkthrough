using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using Sitecore.Mvc.Helpers;

namespace GlassMapperWalkthrough.IoC.Factories
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly IUnityWrapper unityWrapper;

        public UnityControllerFactory(IUnityWrapper unityContainer)
        {
            unityWrapper = unityContainer;
        }

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type controllerType = null;

            if (TypeHelper.LooksLikeTypeName(controllerName))
            {
                controllerType = TypeHelper.GetType(controllerName);
            }

            if (controllerType == null)
            {
                controllerType = GetControllerType(requestContext, controllerName);
            }

            if (controllerType != null)
            {
                var container = UnityWrapper.GetContainer();

                return (IController)container.Resolve(controllerType);
            }
            else
            {
                return base.CreateController(requestContext, controllerName);
            }
        }
    }
}
