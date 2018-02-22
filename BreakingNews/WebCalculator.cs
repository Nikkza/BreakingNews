using System;
using System.Text.RegularExpressions;

namespace BreakingNews
{
    public class WebCalculator : IWebCalculator
    {
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            if (webColl == null || webColl.HtmlCode == null || keyword == null)
            {
                throw new ArgumentNullException("Cant be null");
            }

            if (string.IsNullOrEmpty(webColl.HtmlCode))
            {
                throw new ArgumentException("cant be null HTML");
            }

            return Regex.Matches(webColl.HtmlCode.ToLower(), keyword).Count;
        }
    }
}