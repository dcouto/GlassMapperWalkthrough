using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models;

namespace GlassMapperWalkthrough.Web.Controllers
{
    public class GenericCalloutsListController : BaseController<IGlassBase>
    {
        public GenericCalloutsListController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext) : base(sitecoreContext, renderingContext)
        {
        }

        public ActionResult Index()
        {
            return View("~/Views/GlassMapperWalkthrough/Renderings/GenericCalloutsList.cshtml");
        }
    }
}