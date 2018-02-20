using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    public interface IWebCollector
    {
        string HtmlCode { get; set; }
        void GetHtmlFromUrl(string url);
    }
}
