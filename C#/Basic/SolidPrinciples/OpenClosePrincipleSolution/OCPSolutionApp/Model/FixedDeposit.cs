using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Model
{
    internal class FixedDeposit
    {
        private string _name;
        private double _principle;
        private int _duration;
        private  IFestivalRatePolicy _policy;

        public FixedDeposit(string name, double principle, int duration, IFestivalRatePolicy policy)
        {
            _name = name;
            _principle = principle;
            _duration = duration;
            _policy = policy;
        }

        public double CalculateSimpleInterest()
        {
            return (_principle * _duration * _policy.CalculateRate()) / 100;
        }

        public override string ToString()
        {
            return ($" Name " + Name + "\n Principle Amount " + Principle +
                "\n Duration " + Duration +
                 "\n SI " + CalculateSimpleInterest());
        }

        public string Name { get { return _name; } }
        public double Principle { get { return _principle; } }
        public int Duration { get { return _duration; } }
        public IFestivalRatePolicy Policy { get { return _policy; } }


    }
}
