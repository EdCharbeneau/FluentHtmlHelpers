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

        private readonly AlertStyle alertStyle;

        public AlertBox(HtmlHelper html, string text, AlertStyle style)
        {
            this.html = html;
            this.text = text;
            this.alertStyle = style;
        }

        private string RenderAlert()
        {
            //<div class="alert-box">
            var wrapper = new TagBuilder("div");
            if (alertStyle != AlertStyle.Default)
                wrapper.AddCssClass(alertStyle.ToString().ToLower());
            wrapper.AddCssClass("alert-box");

            //<a href="" class="close">x</a>
            var closeButton = new TagBuilder("a");
            closeButton.AddCssClass("close");
            closeButton.Attributes.Add("href", "");
            closeButton.InnerHtml = "×";

            //build html
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