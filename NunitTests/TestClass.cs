using BreakingNews;
using Castle.Components.DictionaryAdapter.Xml;
using NUnit.Framework;

namespace NunitTests
{
    [NUnit.Framework.TestFixture]
    public class TestClass
    {
        /// <summary>
        /// TestClass
        /// </summary>

        #region Here i started the test WebCalculatorTest 

        [Test]
        public void TestedEmptydUrl()
        {
            WebCollector wc = new WebCollector();
            string s = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(s);
            if (s == string.Empty)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestHttpUrl()
        {
            IWebCollector wc = new WebCollector();
            string s = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(s);
            if (!s.StartsWith("https://"))
            {
                Assert.Fail();
            }

        }

        [Test]
        public void TestUnvalidUrl()
        {
            IWebCollector wc = new WebCollector();
            string s = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(s);
            if (s.StartsWith("http://.."))
            {
                Assert.Fail();
            }
        }
      
        [Test]
        public void TestNullObjekt()
        {
            IWebCollector wc = new WebCollector();
            string s = "https://www.aftonbladet.se/";
            wc.GetHtmlFromUrl(s);
            if (s == null)
            {
                Assert.Fail();
            }

        }
        #endregion

        #region Here i started the test WebCalculatorTest

        [Test]
        public void TestNullObjectICalculator()
        {
            IWebCalculator wc = new WebCalculator();
            IWebCollector wb = new WebCollector();
            string s = "korea";
            wb.GetHtmlFromUrl("https://www.aftonbladet.se/");
            wc.CalculateNumberOfHits(wb, s);

            if (wb == null && s == null)
            {
                Assert.Fail();
            }
        }


        #endregion


    }
}
