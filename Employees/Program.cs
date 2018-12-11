using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Bob", 35, 20);
            Console.WriteLine(emp1);
            Console.WriteLine("Pay amount: " + emp1.CalculatePay().ToString("c"));

            Employee emp2 = new Employee("Ann", 40, 20);
            Console.WriteLine(emp2);
            Console.WriteLine("Pay amount: " + emp2.CalculatePay().ToString("c"));

            PermanentEmployee emp3 = new PermanentEmployee("Chris", 45, 25, 0.1m); // fractions always require m after the numeric value
            Console.WriteLine(emp3);
            Console.WriteLine("Pay amount: " + emp3.CalculatePay().ToString("c"));

            //PermanentEmployee emp4 = (PermanentEmployee) emp1; // invalid
            //Incorrect because you cannot assign a base class object to a derived variable class
            //Console.WriteLine(emp4);

            Employee emp4 = emp3; // Assign derived class class object
            Console.WriteLine(emp4);
            Console.WriteLine("Pay amount: " + emp3.CalculatePay().ToString("c")); // method from the derived class is being called
            // The object's type and not variable's type dictates which version is called

            Console.WriteLine("\n\nPutting employees on one payroll list");
            List<Employee> payroll = new List<Employee>(); // It is an empty list as of right now
            payroll.Add(emp1);
            payroll.Add(emp2);
            payroll.Add(emp3);

            foreach (Employee emp in payroll)
            {
                Console.WriteLine(emp);
                Console.WriteLine("Pay amount: " + emp.CalculatePay().ToString("c")); // display for every employee in the list
                // An example of polymorphism when we took a base class and an inherited class and put them all under a payroll list
            }

            Console.WriteLine("\n\nPress any key");
            Console.ReadKey();
        }
    }
}
