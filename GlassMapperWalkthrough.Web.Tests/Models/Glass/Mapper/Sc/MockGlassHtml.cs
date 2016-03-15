using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Ui;
using Sitecore.Data;

namespace GlassMapperWalkthrough.Web.Tests.Models.Glass.Mapper.Sc
{
    public class MockGlassHtml : IGlassHtml
    {
        public GlassEditFrame EditFrame(string title, string buttons, string path = null, TextWriter output = null)
        {
            throw new NotImplementedException();
        }

        public GlassEditFrame EditFrame<T>(T model, string title = null, TextWriter output = null, params Expression<Func<T, object>>[] fields) where T : class
        {
            throw new NotImplementedException();
        }

        public string Editable<T>(T target, Expression<Func<T, object>> field, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public string Editable<T>(T target, Expression<Func<T, object>> field, Expression<Func<T, string>> standardOutput, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public string RenderImage<T>(T model, Expression<Func<T, object>> field, object parameters = null, bool isEditable = false,
            bool outputHeightWidth = false)
        {
            throw new NotImplementedException();
        }

        public RenderingResult BeginRenderLink<T>(T model, Expression<Func<T, object>> field, TextWriter writer, object attributes = null,
            bool isEditable = false)
        {
            throw new NotImplementedException();
        }

        public string RenderLink<T>(T model, Expression<Func<T, object>> field, object attributes = null, bool isEditable = false,
            string contents = null)
        {
            throw new NotImplementedException();
        }

        public T GetRenderingParameters<T>(string parameters, ID renderParametersTemplateId) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetRenderingParameters<T>(string parameters) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetRenderingParameters<T>(NameValueCollection parameters) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetRenderingParameters<T>(NameValueCollection parameters, ID renderParametersTemplateId) where T : class
        {
            throw new NotImplementedException();
        }

        public string ProtectMediaUrl(string url)
        {
            throw new NotImplementedException();
        }

        public ISitecoreContext SitecoreContext { get; private set; }
    }
}
