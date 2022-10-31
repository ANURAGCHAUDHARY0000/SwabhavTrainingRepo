using System;

namespace StudentEncapApp.Model
{
    internal class Student
    {
        private int _rollNo;
        private string _name;
        private float _cgpa;
        private int _totalFees;
        private int _remainingFees;


        public void SetRollNumber(int rollNo)
        {
            if (rollNo > 0)
            {
                _rollNo = rollNo;
            }
        }
        public void SetName(string name)
        {
            if (name.Length <= 5)
            {
                _name = name;
            }
            else
                _name = " ";
        }

        public void SetCgpa(float cgpa)
        {
            if(cgpa > 1 && cgpa <= 10)
            {
                _cgpa = cgpa;
            }
            else if(cgpa < 1)
            {
                cgpa = 1;
            }
            else
                cgpa = 10;

        }
        public float CalculatePercentageFromCgpa()
        {
            return 9.5f * _cgpa;
        }

        public int GetRollNo()
        {
            return _rollNo;
        }
        public string GetName()
        {
            return _name;
        }
        public float GetCgpa()
        {
            return _cgpa;
        }
        public void SetTotalFees(int totalFees)
        { _totalFees = totalFees;
            _remainingFees = totalFees;    
        }
        public void PayFees(int amount)
        {
            _remainingFees = _remainingFees - amount;
        }
        public int GetTotalFees()
          { return _totalFees; }
        public int GetRemainingFees()
            { return _remainingFees; }
    }
}