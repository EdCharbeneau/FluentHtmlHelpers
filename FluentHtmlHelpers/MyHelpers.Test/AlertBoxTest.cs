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

        [TestMethod]
        public void ShouldCreateSuccessAlert()
        {
            //Spec 
            //Should render a Success alert box
            //@Html.Alert(text:"message", style:AlertStyle.Success)

            //arrange
            string htmlAlert = @"<div class=""alert-box success"">message<a class=""close"" href="""">×</a></div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message", AlertStyle.Success).ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);
        }

        [TestMethod]
        public void ShouldCreateWarningAlert()
        {
            //Spec 
            //Should render a Warning alert box
            //@Html.Alert(text:"message", style:AlertStyle.Warning)

            //arrange
            string htmlAlert = @"<div class=""alert-box warning"">message<a class=""close"" href="""">×</a></div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message", AlertStyle.Warning).ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);
        }

        [TestMethod]
        public void ShouldCreateInfoAlert()
        {
            //Spec 
            //Should render a Info alert box
            //@Html.Alert(text:"message", style:AlertStyle.Info)

            //arrange
            string htmlAlert = @"<div class=""alert-box info"">message<a class=""close"" href="""">×</a></div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message", AlertStyle.Info).ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);
        }

        [TestMethod]
        public void ShouldCreateDefaultAlertWithCloseHidden()
        {
            //Spec
            //Should render an default alert box with close hidden
            //@Html.Alert(text:"message", hideCloseButton:true)

            //arrange
            string htmlAlert = @"<div class=""alert-box"">message</div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message",hideCloseButton:true).ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);

        }

       

    }
}
