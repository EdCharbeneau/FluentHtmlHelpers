using System.Web.Mvc;

namespace MyHelpers
{
    public class AlertBox : IAlertBox
    {
        private readonly string text;

        private AlertStyle alertStyle;

        private bool hideCloseButton;

        private object htmlAttributes;

        public AlertBox(string text, AlertStyle style, bool hideCloseButton, object htmlAttributes = null)
        {
            this.text = text;
            this.alertStyle = style;
            this.hideCloseButton = hideCloseButton;
            this.htmlAttributes = htmlAttributes;
        }

        #region FluentAPI

        public IAlertBoxFluentOptions Success()
        {
            alertStyle = AlertStyle.Success;
            return new AlertBoxFluentOptions(this);
        }

        public IAlertBoxFluentOptions Warning()
        {
            alertStyle = AlertStyle.Warning;
            return new AlertBoxFluentOptions(this);
        }

        public IAlertBoxFluentOptions Info()
        {
            alertStyle = AlertStyle.Info;
            return new AlertBoxFluentOptions(this);
        }

        public IAlertBoxFluentOptions HideCloseButton()
        {
            hideCloseButton = true;
            return new AlertBoxFluentOptions(this);
        }

        public IAlertBoxFluentOptions Attributes(object htmlAttributes)
        {
            this.htmlAttributes = htmlAttributes;
            return new AlertBoxFluentOptions(this);
        }
        #endregion //FluentAPI

        private string RenderAlert()
        {
            //<div class="alert-box">
            var wrapper = new TagBuilder("div");
            //merge attributes
            wrapper.MergeAttributes(htmlAttributes != null ? HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) : null);

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