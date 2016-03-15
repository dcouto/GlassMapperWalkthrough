using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using GlassMapperWalkthrough.Domain.Models;
using Sitecore.Data.Items;

namespace GlassMapperWalkthrough.Web.Controllers
{
    //public interface IGlassController<T> where T : class
    //{
    //    T Layout { get; }
    //    T DataSource { get; }
    //    T Context { get; }
    //    ISitecoreContext SitecoreContext { get; set; }
    //    IGlassHtml GlassHtml { get; set; }
    //    IRenderingContext RenderingContextWrapper { get; set; }

    //    /// <summary>
    //    /// Returns either the item specified by the DataSource or the current context item
    //    /// </summary>
    //    /// <value>The layout item.</value>
    //    // Helper property not to be tested       
    //    Item LayoutItem { get; }

    //    /// <summary>
    //    /// Returns either the item specified by the current context item
    //    /// </summary>
    //    /// <value>The layout item.</value>
    //    // Helper property not to be tested
    //    Item ContextItem { get; }

    //    /// <summary>
    //    /// Returns the item specificed by the data source only. Returns null if no datasource set
    //    /// </summary>
    //    // Helper property not to be tested
    //    Item DataSourceItem { get; }

    //    System.Web.Mvc.ActionResult Index();
    //}

    public class BaseController<T> : Controller where T : class, IGlassBase
    {
        protected readonly ISitecoreContext SitecoreContext;
        protected IRenderingContext RenderingContext;
        
        //private readonly IGlassController<T> _glassController;

        public BaseController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext)
        {
            SitecoreContext = sitecoreContext;
            RenderingContext = renderingContext;

            //_glassController = new GlassController<T>();
        }

        //public BaseController(
        //    ISitecoreContext sitecoreContext,
        //    IGlassHtml glassHtml,
        //    IRenderingContext renderingContext,
        //    HttpContextBase httpContextBase)
        //{
        //    SitecoreContext = sitecoreContext;
        //    //_glassController = new GlassController<T>(sitecoreContext, glassHtml, renderingContext, httpContextBase);
        //}

        //public bool HasDataSource
        //{
        //    get { return _glassController.RenderingContextWrapper.HasDataSource; }
        //}

        private T _computedDataSourceItem;

        /// <summary>
        /// Returns the DataSourceItem casted to T if it's set, otherwise, returns the ContextItem casted to T
        /// </summary>
        public T ComputedDataSourceItem
        {
            get
            {
                if (_computedDataSourceItem == null)
                {
                    if (RenderingContext.HasDataSource)
                    {
                        var datasourceItem = SitecoreContext.GetItem<T>(RenderingContext.GetDataSource());

                        if (datasourceItem != null)
                        {
                            _computedDataSourceItem = datasourceItem;
                        }
                    }
                    else
                    {
                        _computedDataSourceItem = SitecoreContext.GetCurrentItem<T>();
                    }

                    //_computedDataSourceItem = SitecoreContext.Cast<T>(RenderingContext.HasDataSource ? _glassController.ContextItem);
                }

                return _computedDataSourceItem;
            }
        }
    }
}