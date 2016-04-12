using Sitecore.Pipelines.RenderField;

namespace GlassMapperWalkthrough.Framework.Pipelines.RenderField
{
    public class VariableReplacer
    {
        /// <summary>Gets the field value.</summary>
        /// <param name="args">The arguments.</param>
        /// <contract>
        ///   <requires name="args" condition="none" />
        /// </contract>
        public void Process(RenderFieldArgs args)
        {
            args.Result.FirstPart = args.Result.FirstPart.Replace("{{DateTime.Now}}", System.DateTime.Now.ToString());
        }
    }
}
