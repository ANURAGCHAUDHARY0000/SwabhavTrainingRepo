using System;

namespace EngineeringCollegeApp.Model
{
    public enum Branch
    {
        ComputerScience, InformationTechnology,CivilEngineering,CommunicationEngineering,ChemicalEngineering
    }
    internal class Student : Person
    {
        private Branch _branch;
        public Student(int id, string address, string dob, Branch branch) : base(id, address , dob)
        {
            this._branch = branch;
        }

        public Branch Branch { get { return _branch; } }

        public override string ToString()
        {
            String studentDetails = "Student Details \n";
            studentDetails += "Id: " + Id + "\n";
            studentDetails += "Address: " + Address + "\n";
            studentDetails += "DOB: " + Dob + "\n";
            studentDetails += "Branch: " + Branch + "\n";
            return studentDetails;

        }

        //public string GetDetails()
        //{
        //    String studentDetails = "Student Details \n";
        //    studentDetails += "Id: " + Id + "\n";
        //    studentDetails += "Address: " + Address + "\n";
        //    studentDetails += "DOB: " + Dob + "\n";
        //    studentDetails += "Branch: " + Branch + "\n";
        //    return studentDetails;
        //}
    }
}
