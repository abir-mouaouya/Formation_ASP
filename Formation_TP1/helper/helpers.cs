using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Formation_TP1.helper
{
    public class helpers :  TagHelper   
    {
        public helpers() { }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }
    }
}
