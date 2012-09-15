using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyHelpers
{
    /// <summary>
    /// Generates an Alert message
    /// </summary>
    public static class AlertHtmlHelper
    {
        public static AlertBox Alert(this HtmlHelper html, string text)
        {
            return new AlertBox(html, text);
        }
    }
}
        