using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        public static void Main(string[] args) {
            Class1 class1Instance = new Class1(); 
            class1Instance.PrintOperators(); }
        public void PrintOperators()
        {
          byte totalMarks = 100;
          short totalStudents = 1000;
            int totalClasses = 10;
            long totalSchools = 100;
            float totalPercentage = 100.0f;
            double totalPercentageDouble = 100.0;
            decimal totalPercentageDecimal = 100.0m;
            char grade = 'A';
            string schoolName = "ABC School";
            bool isPassed = true;
            Console.WriteLine("hello world!");
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Total Students: " + totalStudents);
            Console.WriteLine("Total Classes: " + totalClasses);
            Console.WriteLine("Total Schools: " + totalSchools);
            Console.WriteLine("Total Percentage: " + totalPercentage);
            Console.WriteLine("Total Percentage Double: " + totalPercentageDouble);
            Console.WriteLine("Total Percentage Decimal: " + totalPercentageDecimal);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("School Name: " + schoolName);
            Console.WriteLine("Is Passed: " + isPassed);
            
        }
    }
}
