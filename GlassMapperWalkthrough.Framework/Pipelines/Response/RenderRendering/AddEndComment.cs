using Sitecore.Configuration;
using Sitecore.Mvc.Pipelines.Response.RenderRendering;

namespace GlassMapperWalkthrough.Framework.Pipelines.Response.RenderRendering
{
    public class AddEndComment : RenderRenderingProcessor
    {
        public override void Process(RenderRenderingArgs args)
        {
            if (Settings.GetBoolSetting(Constants.Settings.RenderStartEndComments, false))
            {
                args.Writer.WriteLine("");
                args.Writer.WriteLine("<!-- END: {0} -->", args.Rendering.Renderer);
                args.Writer.WriteLine("");
            }
        }
    }
}
