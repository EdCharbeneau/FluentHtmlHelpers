using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyHelpers.Test
{
    [TestClass]
    public class AlertBoxTest
    {
        [TestMethod]
        public void ShouldCreateDefaultAlert()
        {
            //Spec
            //Should render an default alert box
            //@Html.Alert(text:"message")

            //arrange
            string htmlAlert = @"<div class=""alert-box"">message<a class=""close"" href="""">×</a></div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message").ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);

        }
    }
}
