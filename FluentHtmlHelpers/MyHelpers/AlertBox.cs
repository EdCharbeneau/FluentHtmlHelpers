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

        private readonly bool hideCloseButton;

        public AlertBox(HtmlHelper html, string text, AlertStyle style, bool hideCloseButton)
        {
            this.html = html;
            this.text = text;
            this.alertStyle = style;
            this.hideCloseButton = hideCloseButton;
        }

        private string RenderAlert()
        {
            //<div class="alert-box">
            var wrapper = new TagBuilder("div");
            if (alertStyle != AlertStyle.Default)
                wrapper.AddCssClass(alertStyle.ToString().ToLower());
            wrapper.AddCssClass("alert-box");


            //build html
            wrapper.InnerHtml = text;
            
            //Add close button
            if (!hideCloseButton)
                wrapper.InnerHtml += RenderCloseButton();
            
            return wrapper.ToString();
        }

        private static TagBuilder RenderCloseButton()
        {
            //<a href="" class="close">x</a>
            var closeButton = new TagBuilder("a");
            closeButton.AddCssClass("close");
            closeButton.Attributes.Add("href", "");
            closeButton.InnerHtml = "×";
            return closeButton;
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