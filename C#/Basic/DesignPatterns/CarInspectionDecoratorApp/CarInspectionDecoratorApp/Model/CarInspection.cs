using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model
{
    internal class CarInspection : ICarService
    {
        private double _price = 600;
        public double GetCost()
        {
            return _price;
        }

        public string GetDetails()
        {
            return $"Car inspection Charge: {_price}";
        }

    }
}
