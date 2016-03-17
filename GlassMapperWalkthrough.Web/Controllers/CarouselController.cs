using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Rendering_Parameters;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;
using GlassMapperWalkthrough.Web.Models;

namespace GlassMapperWalkthrough.Web.Controllers
{
    public class CarouselController : BaseController<ICarousel, ICarousel_Rendering_Parameters>
    {
        public CarouselController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext, IGlassHtml glassHtml) : base(sitecoreContext, renderingContext, glassHtml)
        {
        }

        public ActionResult Index()
        {
            var vm = new CarouselViewModel();
            
            var renderingParameters = RenderingParameters;

            if (renderingParameters != null)
                vm.DisplayPreviousAndNextButtons = renderingParameters.Display_Previous_And_Next_Buttons;

            if (RenderingContext.HasDataSource)
            {
                vm.CarouselSlides.AddRange(ComputedDataSourceItem.Slides);
            }

            return View("~/Views/GlassMapperWalkthrough/Renderings/Carousel.cshtml", vm);
        }
    }
}