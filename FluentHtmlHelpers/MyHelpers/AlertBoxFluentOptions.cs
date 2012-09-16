using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyHelpers
{
    public class AlertBoxFluentOptions : IHtmlString, IAlertBoxFluentOptions
    {
        private readonly AlertBox parent;

        public AlertBoxFluentOptions(AlertBox parent)
        {
            this.parent = parent;
        }

        public IAlertBoxFluentOptions HideCloseButton()
        {
            return parent.HideCloseButton();
        }

        public IAlertBoxFluentOptions Attributes(object htmlAttributes)
        {
            return parent.Attributes(htmlAttributes);
        }

        public override string ToString()
        {
            return parent.ToString();
        }

        public string ToHtmlString()
        {
            return ToString();
        }
    }
}
