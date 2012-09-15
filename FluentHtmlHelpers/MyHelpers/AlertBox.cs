using System;
using System.Web.Mvc;
using System.Web;
using System.Web.UI;

namespace MyHelpers
{
    public class AlertBox : IHtmlString
    {
        private readonly HtmlHelper html;

        private readonly string text;

        public AlertBox(HtmlHelper html, string text)
        {
            this.html = html;
            this.text = text;
        }

        //Render HTML
        public override string ToString()
        {
            return "";
        }

        //Return ToString
        public string ToHtmlString()
        {
            return ToString();
        }
    }
}