using System;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Folders;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;
using GlassMapperWalkthrough.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace GlassMapperWalkthrough.Web.Tests
{
    [TestClass]
    public class GlobalHeaderControllerTests
    {
        private ISitecoreContext _sitecoreContext;
        private IRenderingContext _renderingContext;
        private GlobalHeaderController _controller;

        [TestInitialize]
        public void Initialize()
        {
            _sitecoreContext = Substitute.For<ISitecoreContext>();
            _renderingContext = Substitute.For<IRenderingContext>();
            _controller = new GlobalHeaderController(_sitecoreContext, _renderingContext);
        }

        [TestMethod]
        public void GlobalHeaderController_WhenIndexCalled_ReturnsGlobalHeaderView()
        {
            // ARRANGE

            // ACT
            var viewResult = _controller.Index() as ViewResult;

            // ASSERT
            Assert.AreEqual("~/Views/GlassMapperWalkthrough/Renderings/GlobalHeader.cshtml", viewResult.ViewName);
        }

        [TestMethod]
        public void GlobalHeaderController_WhenIndexCalled_ReturnsGlobalHeaderViewModel()
        {
            // ARRANGE

            // ACT
            var viewModel = _controller.Index() as ViewResult;

            // ASSERT
            Assert.IsNotNull(viewModel);
        }

        [TestMethod]
        public void GlobalHeaderController_WhenHasDataSourceAndSiteHasNoDefaultHeader_UsesDataSource()
        {
            // ARRANGE

            // generate a new random Guid to serve as a "datasource ID"
            var datasourceId = Guid.NewGuid().ToString();

            // a datasource has been set by the content author
            _renderingContext.HasDataSource.Returns(true);
            _renderingContext.GetDataSource().Returns(datasourceId);

            // mock the IHeader_Folder interface
            var datasourceItem = Substitute.For<IHeader_Folder>();

            // mock the value of the datasourceItem.Id property such that
            // it returns the random datasource ID setup above
            datasourceItem.Id.Returns(Guid.Parse(datasourceId));

            // mock the GetItem method such that when called with the datasourceId
            // setup above, it returns the datasourceItem setup above
            _sitecoreContext.GetItem<IHeader_Folder>(datasourceId).Returns(datasourceItem);

            // mock the ISite interface and keep the "Default Header" field blank
            var site = Substitute.For<ISite>();

            // ACT
            var headerFolder = _controller.GetHeaderFolder(site);

            // ASSERT
            Assert.AreEqual(datasourceId, headerFolder.Id.ToString());
        }

        [TestMethod]
        public void GlobalHeaderController_WhenHasDataSourceAndSiteHasDefaultHeader_UsesDataSource()
        {
            // ARRANGE

            // generate a new random Guid to serve as a "datasource ID"
            var datasourceId = Guid.NewGuid().ToString();

            // a datasource has been set by the content author
            _renderingContext.HasDataSource.Returns(true);
            _renderingContext.GetDataSource().Returns(datasourceId);

            // mock the IHeader_Folder interface
            var datasourceItem = Substitute.For<IHeader_Folder>();

            // mock the value of the datasourceItem.Id property such that
            // it returns the random datasource ID setup above
            datasourceItem.Id.Returns(Guid.Parse(datasourceId));

            // mock the GetItem method such that when called with the datasourceId
            // setup above, it returns the datasourceItem setup above
            _sitecoreContext.GetItem<IHeader_Folder>(datasourceId).Returns(datasourceItem);

            // mock the ISite interface and keep the "Default Header" field blank
            var site = Substitute.For<ISite>();

            var defaultHeader = Substitute.For<IHeader_Folder>();

            site.Default_Header.Returns(defaultHeader);

            // ACT
            var headerFolder = _controller.GetHeaderFolder(site);

            // ASSERT
            Assert.AreEqual(datasourceId, headerFolder.Id.ToString());
        }

        [TestMethod]
        public void GlobalHeaderController_WhenHasNoDataSourceAndSiteHasNoDefaultHeader_ReturnsNull()
        {
            // ARRANGE

            // no datasource has been set by the content author
            _renderingContext.HasDataSource.Returns(false);

            // mock the ISite interface and keep the "Default Header" field blank
            var site = Substitute.For<ISite>();

            // ACT
            var headerFolder = _controller.GetHeaderFolder(site);

            // ASSERT
            Assert.AreEqual(Guid.Empty, headerFolder.Id);
        }

        [TestMethod]
        public void GlobalHeaderController_WhenHasNoDataSourceButSiteHasDefaultHeader_UsesDefaultHeader()
        {
            // ARRANGE

            // no datasource has been set by the content author
            _renderingContext.HasDataSource.Returns(false);

            // mock the ISite interface
            var site = Substitute.For<ISite>();

            // mock the IHeader_Folder
            var defaultHeader = Substitute.For<IHeader_Folder>();

            // generate a random Guid
            var defaultHeaderId = Guid.NewGuid();

            // set generated Guid as ID of mock IHeader_Folder
            defaultHeader.Id.Returns(defaultHeaderId);

            // mock the return value of site.Default_Header to return the mock IHeader_Folder
            site.Default_Header.Returns(defaultHeader);

            // ACT
            var headerFolder = _controller.GetHeaderFolder(site);

            // ASSERT
            Assert.AreEqual(defaultHeaderId, headerFolder.Id);
        }
    }
}
