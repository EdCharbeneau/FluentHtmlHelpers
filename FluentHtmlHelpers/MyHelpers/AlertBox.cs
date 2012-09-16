using System.Web.Mvc;

namespace MyHelpers
{
    public class AlertBox : IAlertBox
    {
        private readonly string text;

        private AlertStyle alertStyle;

        private bool hideCloseButton;

        private object htmlAttributes;

        /// <summary>
        /// Returns a div alert box element with the options specified
        /// </summary>
        /// <param name="text">Sets the text to display</param>
        /// <param name="style">Sets style of alert box [Default | Success | Warning | Info ]</param>
        /// <param name="hideCloseButton">Sets the close button visibility</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public AlertBox(string text, AlertStyle style, bool hideCloseButton = false, object htmlAttributes = null)
        {
            this.text = text;
            this.alertStyle = style;
            this.hideCloseButton = hideCloseButton;
            this.htmlAttributes = htmlAttributes;
        }

        #region FluentAPI

        /// <summary>
        /// Sets the display style to Success
        /// </summary>
        public IAlertBoxFluentOptions Success()
        {
            alertStyle = AlertStyle.Success;
            return new AlertBoxFluentOptions(this);
        }

        /// <summary>
        /// Sets the display style to Warning
        /// </summary>
        /// <returns></returns>
        public IAlertBoxFluentOptions Warning()
        {
            alertStyle = AlertStyle.Warning;
            return new AlertBoxFluentOptions(this);
        }

        /// <summary>
        /// Sets the display style to Info
        /// </summary>
        /// <returns></returns>
        public IAlertBoxFluentOptions Info()
        {
            alertStyle = AlertStyle.Info;
            return new AlertBoxFluentOptions(this);
        }
        
        /// <summary>
        /// Sets the close button visibility
        /// </summary>
        /// <returns></returns>
        public IAlertBoxFluentOptions HideCloseButton(bool hideCloseButton = true)
        {
            this.hideCloseButton = hideCloseButton;
            return new AlertBoxFluentOptions(this);
        }

        /// <summary>
        /// An object that contains the HTML attributes to set for the element.
        /// </summary>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
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