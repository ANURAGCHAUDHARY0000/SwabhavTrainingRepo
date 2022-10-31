using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalLib.Model
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private double _gst = 0.18;

        public Hat(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }

        public double GetPrice()
        {
            double finalPrice = _basePrice * _gst;
            return _basePrice + finalPrice;
        }

        public string ShortName
        {
            get { return _shortName; }
        }

        public string LongName { get { return _longName; } }
        public double BasePrice { get { return _basePrice; } }

        public double GST { get { return _gst; } }
    }
}
