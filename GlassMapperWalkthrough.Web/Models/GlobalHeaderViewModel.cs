using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Folders;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;

namespace GlassMapperWalkthrough.Web.Models
{
    public class GlobalHeaderViewModel
    {
        public ISite Site { get; set; }
        public IHeader_Folder Header { get; set; }
    }
}