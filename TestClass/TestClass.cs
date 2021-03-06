﻿using System;
using BreakingNews;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace TestClass
{
    public class TestClass
    {
        /// <summary>
        /// TestClass
        /// </summary>

        #region Here i started the test WebColectorTest 

        [Test]
        public void UrlNotContainsHttp()
        {
            WebCollector wc = new WebCollector();
            string url = "www.aftonbladet.se";
            var ex = Assert.Throws<ArgumentException>(
                () => wc.GetHtmlFromUrl(url));

            Assert.IsTrue(ex.Message.Contains("missing https"));
        }

        [Test]
        public void UrlStringIsNullOrEmpty()
        {
            WebCollector wc = new WebCollector();
            var stringnull = Assert.Throws<ArgumentNullException>(
                () => wc.GetHtmlFromUrl(url: null));
            Assert.IsTrue(stringnull.Message.Contains("Cant be null or empty values"));

            var stringempty = Assert.Throws<ArgumentNullException>(
                () => wc.GetHtmlFromUrl(url: String.Empty));
            Assert.IsTrue(stringempty.Message.Contains("Cant be null or empty values"));
        }

        [Test]
        public void ValidUrl()
        {

            WebCollector wc = new WebCollector();
            string url = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(url);
            Assert.IsTrue(url.Contains("https"));

        }

        #endregion

        #region Here i started the test WebCalculatorTest

        [Test]
        public void TestNullWebCollCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            string s = "hej";
            var results = wc.CalculateNumberOfHits(wb, keyword: s);
            Assert.AreEqual(-1, results);
        }

        [Test]
        public void TestNullObjectHtml()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            wb.HtmlCode = null;
            string s = "key";
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
            string url = "https://www.aftonbladet.se/";
            wb.GetHtmlFromUrl(url);
            var results = wc.CalculateNumberOfHits(wb, keyword: String.Empty);
            Assert.AreEqual(-1, results);
        }

        [Test]
        public void TestKeyWordNullWebCalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            string url = "https://www.aftonbladet.se/";
            wb.GetHtmlFromUrl(url);
            var results = wc.CalculateNumberOfHits(wb, keyword: null);
            Assert.AreEqual(-1, results);
        }

        #endregion

        #region Here i started MoqTest
        [Test]
        public void TestMoq()
        {
            Mock<IWebCollector> moq = new Mock<IWebCollector>();
            IWebCalculator wc = new WebCalculator();
            moq.Setup(x => x.HtmlCode).Returns("koreakoreakorea");
            string s = "korea";
            var results = wc.CalculateNumberOfHits(moq.Object, s);
            Assert.That(results == 3);
        }

        #endregion
    }
}
