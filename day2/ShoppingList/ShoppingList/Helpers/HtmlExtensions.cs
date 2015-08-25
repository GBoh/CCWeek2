using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Helpers
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString FormatCurrency(this HtmlHelper helper, decimal amount)
        {
            if (amount > 10000)
            {
                var tb = new TagBuilder("span");
                tb.MergeAttribute("style", "color:salmon");
                tb.SetInnerText(amount.ToString("c"));
                return MvcHtmlString.Create(tb.ToString(TagRenderMode.EndTag));
            }

            return MvcHtmlString.Create(amount.ToString("c"));
        }
    }
}