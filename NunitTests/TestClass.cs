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
        public void TestCodeWebCollector()
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
        [Test]
        public void TestWebCalculator()
        {
            Assert.Catch<ArgumentNullException>(TestNullOrEmptyWebCalculator);
            Assert.Catch<ArgumentException>(TestHtmlStringEmptyWebCalculator);
        }

        public void TestNullOrEmptyWebCalculator()
        {
            WebCalculator wc = new WebCalculator();
            WebCollector wb = new WebCollector();
            string s = "hej";
            wb = null;
            wc.CalculateNumberOfHits(wb, s);
        }

        public void TestHtmlNullWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = null;
            string s = "testing";
            wc.CalculateNumberOfHits(wb, s);
        }

        public void TestHtmlStringEmptyWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = String.Empty;
            string s = "testing";
            wc.CalculateNumberOfHits(wb, s);
        }

        #endregion


    }
}
