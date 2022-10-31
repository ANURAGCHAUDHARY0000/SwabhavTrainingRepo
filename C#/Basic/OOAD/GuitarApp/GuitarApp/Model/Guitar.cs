using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Service;

namespace GuitarApp.Model
{
    internal class Guitar
    {
        private readonly String serialNumber;
        private double price;
        private GuitarSpec spec;

        public Guitar(String serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public Guitar()
        {

        }

        public String SerialNumber { get { return serialNumber; } }
        public double Price { set {  price = value; } get { return price; } }
        public GuitarSpec Spec { get { return spec; } }



    }
}
