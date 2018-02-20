using System.Text.RegularExpressions;

namespace BreakingNews
{
    public class WebCalculator : IWebCalculator
    {
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            return Regex.Matches(webColl.HtmlCode.ToLower(), keyword).Count;
        }
    }
}
