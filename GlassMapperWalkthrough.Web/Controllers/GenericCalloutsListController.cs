using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;

namespace GlassMapperWalkthrough.Web.Controllers
{
    public class GenericCalloutsListController : BaseController<IGeneric_Callout_List>
    {
        public GenericCalloutsListController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext) : base(sitecoreContext, renderingContext)
        {
        }

        public ActionResult Index()
        {
            return View("~/Views/GlassMapperWalkthrough/Renderings/GenericCalloutsList.cshtml", this.ComputedDataSourceItem);
        }
    }
}