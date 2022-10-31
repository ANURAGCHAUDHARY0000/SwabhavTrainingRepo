using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model
{
    internal class OilChange : ICarService
    {
        private ICarService _service;
        private double _price = 1200;

        public OilChange(ICarService service)
        {
            _service = service;
        }

        public double GetCost()
        {
            return _price + _service.GetCost();
        }

        public string GetDetails()
        {
            string details = _service.GetDetails();
            details += $"\r\nOil changed Charge : {_price}";
            return details;
        }




    }
}
