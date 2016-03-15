using System.Web.Mvc;
using GlassMapperWalkthrough.IoC.Factories;
using Sitecore.Pipelines;

namespace GlassMapperWalkthrough.IoC.Initializers
{
    public class UnityControllerFactoryInitializer
    {
        public void Process(PipelineArgs args)
        {
            ControllerBuilder.Current.SetControllerFactory(new UnityControllerFactory(new UnityWrapper()));
        } 
    }
}
