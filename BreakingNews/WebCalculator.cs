using System.Text.RegularExpressions;

namespace BreakingNews
{
    public class WebCalculator : IWebCalculator
    {
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {

            if (string.IsNullOrEmpty(webColl.HtmlCode) || webColl == null || string.IsNullOrEmpty(keyword))
            {
                return -1;
            }

            if (Regex.Matches(webColl.HtmlCode.ToLower(), keyword).Count == 3)
            {

                return 3;
            }

            return Regex.Matches(webColl.HtmlCode.ToLower(), keyword).Count;


        }
    }
}