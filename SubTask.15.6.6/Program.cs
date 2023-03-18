using SubTask._15._6._6;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1
{
    class Program : SubTask._15._6._6.Classroom
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = classes.SelectMany(c => c.Students).ToArray();
            return allStudents;
        }
    }
}