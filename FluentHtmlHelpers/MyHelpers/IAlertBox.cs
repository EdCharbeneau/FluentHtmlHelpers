using System.Web;

namespace MyHelpers
{
    public interface IAlertBox : IHtmlString, IAlertBoxFluentOptions
    {
        IAlertBoxFluentOptions Success();
        IAlertBoxFluentOptions Warning();
        IAlertBoxFluentOptions Info();
    }
}