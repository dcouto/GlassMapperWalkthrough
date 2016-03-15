using System;
using System.Web;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Web.Controllers;
using GlassMapperWalkthrough.Web.Tests.Models.Glass.Mapper.Sc;
using GlassMapperWalkthrough.Web.Tests.Models.Glass.Mapper.Sc.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace GlassMapperWalkthrough.Web.Tests
{
    [TestClass]
    public class GlobalHeaderControllerTests
    {
        //[TestMethod]
        //public void Controller_Is_Not_Null()
        //{
        //    var sitecoreContext = Substitute.For<ISitecoreContext>();
        //    var glassHtml = Substitute.For<IGlassHtml>();
        //    var renderingContext = Substitute.For<IRenderingContext>();
        //    var httpContextBase = Substitute.For<HttpContextBase>();

        //    var controller = new GlobalHeaderController(sitecoreContext, glassHtml, renderingContext, httpContextBase);

        //    Assert.IsNotNull(controller);
        //}

        //[TestMethod]
        //public void Prefer_DataSourceItem_When_DataSourceItem_Is_Set()
        //{
        //    ISitecoreContext sitecoreContext = new MockSitecoreContext();
        //    var glassHtml = new MockGlassHtml();
        //    var renderingContext = new MockRenderingContext(Guid.NewGuid().ToString("B"));
        //    var httpContextBase = Substitute.For<HttpContextBase>();

        //    var controller = new GlobalHeaderController(sitecoreContext, glassHtml, renderingContext, httpContextBase);

        //    var headerFolder = controller.GetHeaderFolder(null);

        //    Assert.IsNotNull(headerFolder);
        //}

        //[TestMethod]
        //public void Controller_Prefers_DataSourceItem_When_DataSourceItem_Is_Set()
        //{
        //    var sitecoreContext = Substitute.For<ISitecoreContext>();
        //    var glassHtml = Substitute.For<IGlassHtml>();
        //    var renderingContext = new MockRenderingContext("");
        //    var httpContextBase = Substitute.For<HttpContextBase>();

        //    var controller = new GlobalHeaderController(sitecoreContext, glassHtml, renderingContext, httpContextBase);

            

        //    //controller.DataSourceItem = new Item(ID.NewID, null, null);
        //}
    }
}
