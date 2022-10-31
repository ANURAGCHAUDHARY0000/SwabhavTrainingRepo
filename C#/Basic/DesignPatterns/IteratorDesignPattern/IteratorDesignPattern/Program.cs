using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorDesignPattern.Model;

//C# allows us to Access the elements of a collection without exposing
//its internal data structure. That means it allows you to navigate through
//a different collection of data using a common interface without knowing about
//their underlying implementation.


namespace IteratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection collection = new ConcreteCollection();

            collection.AddEmployee(new Employee("Anurag", 100));
            collection.AddEmployee(new Employee("Pranaya", 101));
            collection.AddEmployee(new Employee("Santosh", 102));
            

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
        }
    }
}
