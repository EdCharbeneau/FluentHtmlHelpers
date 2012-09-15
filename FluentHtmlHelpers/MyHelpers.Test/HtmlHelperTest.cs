using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyHelpers.Test
{
    [TestClass]
    public class HtmlHelperTest
    {
        [TestMethod]
        public void ShouldCreateHtmlHelper()
        {
            //arrange
            var html = HtmlHelperFactory.Create();

            //assert
            Assert.IsNotNull(html);
        }
    }

}
