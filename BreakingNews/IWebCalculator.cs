namespace BreakingNews
{
    public interface IWebCalculator
    {
        int CalculateNumberOfHits(IWebCollector webColl, string keyword);
    }
}

