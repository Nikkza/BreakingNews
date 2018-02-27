using System;
using System.Text.RegularExpressions;

namespace BreakingNews
{
    public class WebCalculator : IWebCalculator
    {
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            if (string.IsNullOrEmpty(webColl.HtmlCode) || string.IsNullOrEmpty(keyword) || webColl == null)
            {
                return -1;
            }

            return Regex.Matches(webColl.HtmlCode.ToLower(), keyword).Count;
        }
    }
}