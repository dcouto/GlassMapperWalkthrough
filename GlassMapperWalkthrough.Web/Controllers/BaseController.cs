using System;
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
                if (_computedDataSourceItem == null || _computedDataSourceItem.Id == Guid.Empty)
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
        private readonly IGlassHtml _glassHtml;

        protected BaseController(ISitecoreContext sitecoreContext, IRenderingContext renderingContext, IGlassHtml glassHtml) : base(sitecoreContext, renderingContext)
        {
            _glassHtml = glassHtml;
        }

        private TRenderingParameters _renderingParameters;

        /// <summary>
        /// Returns the DataSourceItem casted to TRenderingParameters if it's set, otherwise, returns null
        /// </summary>
        protected TRenderingParameters RenderingParameters
        {
            get
            {
                if (_renderingParameters == null)
                {
                    var renderingParameters = RenderingContext.GetRenderingParameters();

                    _renderingParameters = renderingParameters.HasValue()
                        ? _glassHtml.GetRenderingParameters<TRenderingParameters>(renderingParameters)
                        : null;
                }

                return _renderingParameters;
            }
        }
    }
}