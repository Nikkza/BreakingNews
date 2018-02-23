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
            //Assert.Catch<ArgumentNullException>(TestNullOrEmptyWebCalculator);
            // Assert.Catch<ArgumentException>(TestHtmlStringEmptyWebCalculator);
        }
        [Test]
        public void TestNullWebCollCalculator()
        {
            WebCalculator wc = new WebCalculator();
            WebCollector wb = new WebCollector();
            string s = "hej";
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }
        [Test]
        public void TestHtmlNullWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = null;
            string s = "testing";
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }
        [Test]
        public void TestHtmlStringEmptyWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = String.Empty;
            string s = "testing";
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }
        [Test]
        public void TestKeyWordStringEmptyWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = "Sträng";
            string s = String.Empty;
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }
        [Test]
        public void TestKeyWordNullWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = "Sträng";
            string s = null;
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }

        #endregion


    }
}
