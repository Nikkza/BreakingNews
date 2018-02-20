using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    public class WebCollector : IWebCollector
    {
        public string HtmlCode { get; set; }

        public void GetHtmlFromUrl(string url)
        {
            using (var client = new WebClient())
            {
                HtmlCode = client.DownloadString(url).ToLower();
            }
        }


    }
}
