using System;
using Glass.Mapper.Sc.Web;

namespace GlassMapperWalkthrough.Web.Tests.Models.Glass.Mapper.Sc.Web
{
    public class MockRenderingContext : IRenderingContext
    {
        private string _dataSource;

        public MockRenderingContext()
        {
            
        }

        public MockRenderingContext(string dataSource)
        {
            _dataSource = dataSource;
        }

        public string GetRenderingParameters()
        {
            throw new NotImplementedException();
        }

        public string GetDataSource()
        {
            return _dataSource;
        }

        public bool HasDataSource
        {
            get { return !string.IsNullOrEmpty(_dataSource); }
        }
    }
}
