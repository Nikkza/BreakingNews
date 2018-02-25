using BreakingNews;
using Moq;
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
        public void TestCodeWebbCollector()
        {
            Assert.Catch<ArgumentException>(UrlNotContainsHttp);
            Assert.Catch<ArgumentNullException>(StringIsNullOrEmpty);
        }

        [Test]
        public void ValidUrl()
        {
            WebCollector wc = new WebCollector();
            string url = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(url);
            Assert.IsTrue(url.StartsWith("https"));
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
            string url = "www.aftonbladet.se";
            wc.GetHtmlFromUrl(url);
        }
        #endregion

        #region Here i started the test WebCalculatorTest

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
            wb.HtmlCode = "https://www.aftonbladet.se/";
            string s = String.Empty;
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }

        [Test]
        public void TestKeyWordNullWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = "https://www.aftonbladet.se/";
            string s = null;
            var results = wc.CalculateNumberOfHits(wb, s);
            Assert.AreEqual(-1, results);
        }

        #endregion

        #region Here i started MoqTest
        [Test]
        public void TestMoq()
        {
            Mock<IWebCollector> moq = new Mock<IWebCollector>();
            IWebCalculator wc = new WebCalculator();
            moq.SetupAllProperties();
            moq.Object.HtmlCode = "koreakoreakorea";
            string s = "korea";
            var results = wc.CalculateNumberOfHits(moq.Object, s);
            Assert.That(results == 3);

            #endregion
        }
    }
}
