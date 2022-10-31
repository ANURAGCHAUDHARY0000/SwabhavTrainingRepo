using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Model;

namespace GuitarApp.Service
{
    internal class Inventory
    {
        private List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }

        public void AddGuitar(String serialNumber, double price, Builder builder, String model, GuitarType type, BackWood backWood,
          TopWood topWood, int numStrings)
        {
            GuitarSpec guitarSpec = new GuitarSpec(builder, model, type, backWood, topWood, numStrings);
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            _guitars.Add(guitar);
        }
        public Guitar GetGuitar(String serialNumber)
        {
            foreach (Guitar guitar in _guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSepc)
        {
            List<Guitar> matchingGuitar = new List<Guitar>();
            foreach (var guitar in _guitars)
            {
                if (guitar.Spec.Matches(searchSepc))
                {
                    matchingGuitar.Add(guitar);
                }
            }
               return matchingGuitar;

        }


    }
}