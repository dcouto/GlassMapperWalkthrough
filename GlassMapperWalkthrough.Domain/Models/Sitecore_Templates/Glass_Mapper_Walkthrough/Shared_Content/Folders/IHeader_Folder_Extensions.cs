using System.Collections.Generic;
using System.Linq;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;

namespace GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Folders
{
    public static class IHeader_Folder_Extensions
    {
        public static IEnumerable<IText_Link> GetMainNavigationLinks(this IHeader_Folder item)
        {
            var mainNavFolder = item.Children.FirstOrDefault(i => i is IMain_Navigation_Folder);

            if (mainNavFolder == null)
                return Enumerable.Empty<IText_Link>();

            return mainNavFolder.Children.OfType<IText_Link>();
        }
    }
}
