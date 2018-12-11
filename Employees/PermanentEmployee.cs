using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // Make the class inherit from Employee

    class PermanentEmployee : Employee
    {
        // Added data

        private decimal rrspPct;

        // Derived class constructors
        public PermanentEmployee (string n, decimal h, decimal p, decimal r) : base(n, h, p) // Passes the first three values to the base class constructor
        {
            rrspPct = r;
        }

        // Public methods

        public override string ToString()
        {
            string output = base.ToString(); // Call the method from the base class
            output += "\nRRSP deduction " + rrspPct.ToString("p"); // adding the percentage to the base string 
            return output;
        }
        
        public decimal CalculateRRSP()
        {
            return base.CalculatePay() * rrspPct;
        }

        public override decimal CalculatePay()
        {
            decimal basePay = base.CalculatePay();
            decimal rrspAmount = CalculateRRSP();
            return basePay - rrspAmount;

        }

    }
}
