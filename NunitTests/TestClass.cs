using BreakingNews;
using NUnit.Framework;
using System;

namespace NunitTests
{
    [TestFixture]
    public class TestClass
    {
        /// <summary>
        /// TestClass
        /// </summary>

        #region Here i started the test WebColectorTest 

        [Test]
        public void TestCode()
        {
            Assert.Catch<ArgumentNullException>(StringIsNullOrEmpty);
            Assert.Catch<ArgumentException>(UrlNotContainsHttp);
        }


        [Test]
        public void ValidUrl()
        {
            WebCollector wc = new WebCollector();
            string url = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(url);
            Assert.IsTrue(url.Contains("https://"));
        }

        public void StringIsNullOrEmpty()
        {
            WebCollector wc = new WebCollector();
            string nullobject = null;
            wc.GetHtmlFromUrl(nullobject);
            string empty = String.Empty;
            wc.GetHtmlFromUrl(empty);
        }

        public void UrlNotContainsHttp()
        {
            WebCollector wc = new WebCollector();
            string url = "www.aftonladet.se";
            wc.GetHtmlFromUrl(url);
        }





        #endregion

        #region Here i started the test WebCalculatorTest



        #endregion


    }
}
