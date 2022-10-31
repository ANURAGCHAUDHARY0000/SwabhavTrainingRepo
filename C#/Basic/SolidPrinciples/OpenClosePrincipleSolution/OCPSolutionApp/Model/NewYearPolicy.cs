using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Model
{
    internal class NewYearPolicy : IFestivalRatePolicy
    {
        public float CalculateRate()
        {
            return 8.5f;
        }
    }
}
