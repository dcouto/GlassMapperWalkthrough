using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Folders;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;
using GlassMapperWalkthrough.Web.Models;

namespace GlassMapperWalkthrough.Web.Controllers
{
    public class GlobalHeaderController : BaseController<IHeader_Folder>
    {
        public GlobalHeaderController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext) : base(sitecoreContext, renderingContext)
        {
        }

        public ActionResult Index()
        {
            var vm = new GlobalHeaderViewModel();

            vm.Site = GetSiteItem();

            vm.Header = GetHeaderFolder(vm.Site);

            return View("~/Views/GlassMapperWalkthrough/Renderings/GlobalHeader.cshtml", vm);
        }

        public ISite GetSiteItem()
        {
            return SitecoreContext.GetRootItem<ISite>();
        }

        public IHeader_Folder GetHeaderFolder(ISite site)
        {
            if (RenderingContext.HasDataSource)
            {
                return ComputedDataSourceItem;
            }

            if (site != null)
            {
                return site.Default_Header;
            }

            return null;
        }
    }
}