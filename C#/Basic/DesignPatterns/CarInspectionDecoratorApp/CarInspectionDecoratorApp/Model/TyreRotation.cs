using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model
{
    internal class TyreRotation : ICarService
    {
        private ICarService _service;
        private double _price = 350;

        public TyreRotation(ICarService service)
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
            details += $"\r\nTyre Rotation Charge : {_price}";
            return details;
        }
    }
}
