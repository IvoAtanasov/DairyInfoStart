namespace DairyWeb.CustomHtmlHelpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web;
    using System.Web.Mvc;

 
    public static class CustomHtmlHelpers
    {
        public static IHtmlString StarRate(this HtmlHelper helper, int rate,int maxRate)
        {
            StringBuilder starRate = new StringBuilder();
            for (int counter = 1; counter <= maxRate; counter++) {
                TagBuilder tb = new TagBuilder("img");
                if (counter <= rate)
                {
                    tb.Attributes.Add("src", "/Content/Images/knewstuff.png");
                }
                else {
                    tb.Attributes.Add("src", "/Content/Images/14_star.png");
                }
                tb.Attributes.Add("id", "str" + counter);
                tb.Attributes.Add("data-number",counter.ToString());
                tb.Attributes.Add("class", "RateStare");
                starRate.Append(tb.ToString(TagRenderMode.SelfClosing));
            }
                return new MvcHtmlString(starRate.ToString());
        }
    }
}