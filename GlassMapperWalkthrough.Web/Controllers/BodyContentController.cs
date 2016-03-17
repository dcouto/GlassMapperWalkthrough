using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Pages.Base_Content;

namespace GlassMapperWalkthrough.Web.Controllers
{
    public class BodyContentController : BaseController<IBody_Content>
    {
        public BodyContentController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext) : base(sitecoreContext, renderingContext)
        {
        }

        public ActionResult Index()
        {
            return View("~/Views/GlassMapperWalkthrough/Renderings/BodyContent.cshtml");
        }
    }
}