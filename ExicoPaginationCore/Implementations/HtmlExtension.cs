using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExicoPaginationCore
{
    public static class HtmlExtension
    {
        public static IHtmlContent RenderPagination(this IHtmlHelper html, int totalItems, int itemsPerPage,IPagingConfig config)
        {
            var pager = (IPager)html.ViewContext.HttpContext.RequestServices.GetService(typeof(IPager));
            return pager.RenderPagination(totalItems, itemsPerPage,config);
        }
    }
}
