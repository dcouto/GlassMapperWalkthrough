using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using Microsoft.Practices.Unity;

namespace GlassMapperWalkthrough.IoC
{
    public class UnityWrapper : IUnityWrapper
    {
        private static IUnityContainer container { get; set; }

        public UnityWrapper()
        {
            container = new UnityContainer();
            RegisterTypes();
        }

        public void RegisterTypes()
        {
            container
                // apparently Unity does not choose the parameterless constructor by default
                // (Chris says Unity will choose the constructor with the most parameters by default)
                // so if you pass in a new InjectionConstructor() and specify an empty constructor,
                // this tells Unity to target the parameterless constructor of the registering type
                .RegisterType<ISitecoreContext, SitecoreContext>(new InjectionConstructor())
                .RegisterType<IRenderingContext, RenderingContextMvcWrapper>();
        }

        public static IUnityContainer GetContainer()
        {
            return container;
        }
    }
}
