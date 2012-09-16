using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyHelpers.Test
{
    [TestClass]
    public class AlertBoxFluentTest
    {
        [TestMethod]
        public void ShouldCreateSuccessAlert()
        {
            //Spec 
            //Should render a Success alert box
            //@Html.Alert(text:"message").Success()
            //arrange
            string htmlAlert = @"<div class=""alert-box success"">message<a class=""close"" href="""">×</a></div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message").Success().ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);
        }

        [TestMethod]
        public void ShouldCreateSuccessAlertWithCloseHidden()
        {
            //Spec 
            //Should render a Success alert box with close button hidden
            //@Html.Alert(text:"message").Success().HideCloseButton()
            //arrange
            string htmlAlert = @"<div class=""alert-box success"">message</div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message").Success().HideCloseButton().ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);
        }

        [TestMethod]
        public void ShouldCreateSuccessAlertWithAttributes()
        {
            //Spec
            //Should render an default alert box
            //@Html.Alert(text:"message").Success().Attributes(new { id = "MyControlId"})

            //arrange
            string htmlAlert = @"<div class=""alert-box success"" id=""MyControlId"">message<a class=""close"" href="""">×</a></div>";
            var html = HtmlHelperFactory.Create();

            //act
            var result = html.Alert("message").Success().Attributes( new { id = "MyControlId" }).ToHtmlString();

            //assert
            Assert.AreEqual(htmlAlert, result, ignoreCase: true);

        }     
    }
}
