using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        /// <summary>
        /// Generates an Alert message
        /// </summary>
        public static AlertBox Alert(this HtmlHelper html,
            string text,
            AlertStyle alertStyle = AlertStyle.Default,
            bool hideCloseButton = false,
            object htmlAttributes = null
            )
        {
            return new AlertBox(text, alertStyle, hideCloseButton, htmlAttributes);
        }

        // Strongly typed
        /// <summary>
        /// Generates an Alert message
        /// </summary>
        public static AlertBox AlertFor<TModel, TTextProperty>(this HtmlHelper<TModel> html,
            Expression<Func<TModel, TTextProperty>> expression,
            AlertStyle alertStyle = AlertStyle.Default,
            bool hideCloseButton = false,
            object htmlAttributes = null
            )
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            return new AlertBox((string)metadata.Model, alertStyle, hideCloseButton, htmlAttributes);
        }

        /// <summary>
        /// Generates an Alert message
        /// </summary>
        public static AlertBox AlertFor<TModel, TTextProperty, TStyleProperty>(this HtmlHelper<TModel> html,
            Expression<Func<TModel, TTextProperty>> textExpression,
            Expression<Func<TModel, TStyleProperty>> styleExpression,
            bool hideCloseButton = false,
            object htmlAttributes = null
            )
        {
            var text = (string)ModelMetadata.FromLambdaExpression(textExpression, html.ViewData).Model;
            var alertStyle = (AlertStyle)ModelMetadata.FromLambdaExpression(styleExpression, html.ViewData).Model;

            return new AlertBox(text, alertStyle, hideCloseButton, htmlAttributes);
        }

      
    }
}
        