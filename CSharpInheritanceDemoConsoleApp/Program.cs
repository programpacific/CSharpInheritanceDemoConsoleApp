using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();

            // Added just to make sure it's working alright!
            Console.ReadLine();


        }
    }
}
