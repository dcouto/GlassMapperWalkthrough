using System.Web.Mvc;
using Glass.Mapper;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using GlassMapperWalkthrough.Domain.Models;

namespace GlassMapperWalkthrough.Web.Controllers
{
    public class BaseController<T> : Controller where T : class, IGlassBase
    {
        protected readonly ISitecoreContext SitecoreContext;
        protected readonly IRenderingContext RenderingContext;

        protected BaseController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext)
        {
            SitecoreContext = sitecoreContext;
            RenderingContext = renderingContext;
        }

        private T _computedDataSourceItem;

        /// <summary>
        /// Returns the DataSourceItem casted to T if it's set, otherwise, returns the ContextItem casted to T
        /// </summary>
        protected T ComputedDataSourceItem
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
                }

                return _computedDataSourceItem;
            }
        }
    }

    public class BaseController<TDataSource, TRenderingParameters> : BaseController<TDataSource> where TDataSource : class, IGlassBase where TRenderingParameters : class, IGlassBase
    {
        private readonly IGlassHtml GlassHtml;

        protected BaseController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext, IGlassHtml glassHtml) : base(sitecoreContext, renderingContext)
        {
            GlassHtml = glassHtml;
        }

        private TRenderingParameters _renderingParameters;

        protected TRenderingParameters RenderingParameters
        {
            get
            {
                if (_renderingParameters == null)
                {
                    var renderingParameters = RenderingContext.GetRenderingParameters();

                    _renderingParameters = renderingParameters.HasValue()
                        ? GlassHtml.GetRenderingParameters<TRenderingParameters>(renderingParameters)
                        : null;
                }

                return _renderingParameters;
            }
        }
    }
}