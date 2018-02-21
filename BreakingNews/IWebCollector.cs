namespace BreakingNews
{
    public interface IWebCollector
    {
        string HtmlCode { get; set; }
        void GetHtmlFromUrl(string url);
    }
}
