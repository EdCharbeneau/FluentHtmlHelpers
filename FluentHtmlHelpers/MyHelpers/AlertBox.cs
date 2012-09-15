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

        private string RenderAlert()
        {

            var wrapper = new TagBuilder("div");
            wrapper.AddCssClass("alert-box");

            var closeButton = new TagBuilder("a");
            closeButton.AddCssClass("close");
            closeButton.Attributes.Add("href", "");
            closeButton.InnerHtml = "×";

            wrapper.InnerHtml = text;
            wrapper.InnerHtml += closeButton.ToString();

            return wrapper.ToString();
        }

        //Render HTML
        public override string ToString()
        {
            return RenderAlert();
        }

        //Return ToString
        public string ToHtmlString()
        {
            return ToString();
        }
    }
}