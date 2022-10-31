using System;


namespace EngineeringCollegeApp.Model
{
    internal class Person
    {
        private int _id;
        private string _address;
        private string _dob;

        public Person(int id, string address, string dob)
        {
            _id = id;
            _address = address;
            _dob = dob;
        }

        public int Id { get { return _id; } }
        public String Address { get { return _address; } }
        public String Dob { get { return _dob; } }



    }
}
