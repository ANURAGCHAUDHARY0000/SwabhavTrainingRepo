using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEventApp
{
    internal class Calculator
    {
        public event Action<int, int, int> OnAdditionOperationComplete = null;
        public event Action<int, int, int> OnSubtractionOperationComplete = null;

        public void Add(int a, int b)
        {
            var add = a + b;
            if (OnAdditionOperationComplete != null)
            {
                OnAdditionOperationComplete(a, b, add);
            }
        }

        public void Subtract(int a,int b)
        {
            var sub = a - b;
            if (OnSubtractionOperationComplete != null)
            {
                OnSubtractionOperationComplete(a, b, sub);
            }
        }
    }
}
