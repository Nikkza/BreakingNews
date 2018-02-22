using System;
using System.Net;

namespace BreakingNews
{
    public class WebCollector : IWebCollector
    {
        public string HtmlCode { get; set; }

        public void GetHtmlFromUrl(string url)
        {
            // if string is null or empty
            // throw an exception!!

            if (string.IsNullOrEmpty(url) || url == null)
            {
                throw new ArgumentNullException("is null or empty");
            }


            if (!url.Contains("https://") || url.Contains("http://"))
            {
                throw new ArgumentException("Missing http or https");
            }

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                using (var client = new WebClient())
                {
                    HtmlCode = client.DownloadString(url).ToLower();
                }
            }


        }

    }
}
