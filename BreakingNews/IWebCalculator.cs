using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    public interface IWebCalculator
    {
       int CalculateNumberOfHits(IWebCollector webColl, string keyword);
    }
}

