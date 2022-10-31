using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    internal class FixedDeposit
    {
        private string _name;
        private double _principle;
        private int _duration;
        private FestivalType _festival;

        public FixedDeposit(string name,double principle,int duration,FestivalType festival)
        {
            _name = name;
            _principle = principle;
            _duration = duration;
            _festival = festival;
        }

        public double CalculateRate()
        {
            double rate = 0;
            if (_festival == FestivalType.DIWALI)
            { rate = 9; }
            if (_festival == FestivalType.RAMZAN)
            { rate = 8; }
            if (_festival == FestivalType.NEWYEAR)
            { rate = 8.5; }
            if (_festival == FestivalType.NORMAL)
            { rate = 7; }
                return rate;
        }

        public double CalculateSimpleInterest()
        {
            return (_principle * _duration * CalculateRate())/100;
        }

        public override string ToString()
        {
            return ($" Name " + Name + "\n Principle Amount " + Principle +
                "\n Duration " + Duration + "\n Festival " + Festival +
                "\n Rate  " + CalculateRate() + "\n SI " + CalculateSimpleInterest());
        }

        public string Name { get { return _name; } }

        public double Principle { get { return _principle; } }

        public int Duration { get { return _duration; } }

        public FestivalType Festival { get { return _festival; } }


    }
}
