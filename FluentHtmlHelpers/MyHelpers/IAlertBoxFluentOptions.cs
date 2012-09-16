using System.Web;

namespace MyHelpers
{
    public interface IAlertBoxFluentOptions : IHtmlString
    {
        IAlertBoxFluentOptions HideCloseButton();
        IAlertBoxFluentOptions Attributes(object htmlAttributes);
    }
}