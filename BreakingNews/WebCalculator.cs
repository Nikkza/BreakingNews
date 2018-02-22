using System;
using System.Text.RegularExpressions;

namespace BreakingNews
{
    public class WebCalculator : IWebCalculator
    {

        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            if (string.IsNullOrEmpty(keyword) || keyword == null)
            {
                throw new ArgumentNullException("Cant be null or empty");
            }
            return Regex.Matches(webColl.HtmlCode.ToLower(), keyword).Count;
        }

    }
}