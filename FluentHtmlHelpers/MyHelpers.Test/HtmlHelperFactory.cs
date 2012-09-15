using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace MyHelpers.Test
{
    class HtmlHelperFactory
    {
        public static HtmlHelper Create()
        {
            var vc = new ViewContext();
            vc.HttpContext = new FakeHttpContext();
            var html = new HtmlHelper(vc, new FakeViewDataContainer());
            return html;
        }

        private class FakeHttpContext : HttpContextBase
        {
            private readonly Dictionary<object, object> items = new Dictionary<object, object>();

            public override IDictionary Items
            {
                get
                {
                    return items;
                }
            }
        }

        private class FakeViewDataContainer : IViewDataContainer
        {
            private ViewDataDictionary viewData = new ViewDataDictionary();
            public ViewDataDictionary ViewData
            {
                get
                {
                    return viewData;
                }
                set
                {
                    viewData = value;
                }
            }
        }
    }
}