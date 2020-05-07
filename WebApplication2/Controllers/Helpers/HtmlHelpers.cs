using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace WebApplication2.Controllers.Helpers
{
    /*public static class HtmlHelpers
    {
        public static IHtmlContent Action(this IHtmlHelper helper, string action,  string controller,  object parameters=null)
        {
            var area = (string)helper.ViewContext.RouteData.Values["area"];
            return Action(helper, action, controller, area, parameters);
        }
        public static IHtmlContent Action(this HtmlHelper helper, string action, string controller, string area, object parameters = null)
        {
            if (action == null)
                throw new ArgumentException("action");
            if (controller == null){
                throw new ArgumentException("controller");
            }
            var task = RenderActionAsync(helper, action, controller, area, parameters);
            return task.Result;
        }

        private static object RenderActionAsync(HtmlHelper helper, string action, string controller, string area, object parameters)
        {
            throw new NotImplementedException();
        }
    }*/
}
