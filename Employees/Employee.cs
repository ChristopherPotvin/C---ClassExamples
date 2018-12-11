using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        // Define the constants
        const decimal OT_RATE = 1.5m;
        const decimal FUll_WEEK = 37.5m; // hours in a full week

        // Define the private data
        private string name;
        private decimal hours; // hours the employee works
        private decimal payRate; // their pay per hour 

        // constructor
        public Employee (string n, decimal h, decimal p)
        {
            name = n;
            hours = h;
            payRate = p;
        }
    
        // Public methods
        public virtual decimal CalculatePay() // Virtual means that it can be overriden with the override function in the inherited class
        {
            if (hours <= FUll_WEEK)
            
                return hours * payRate;
            
            else
            
                return FUll_WEEK * payRate + (hours - FUll_WEEK) * payRate * OT_RATE; // overtime rate if the hours go over full week
            
        }

        // WHAT ARE THE DIFFERENCES BETWEEN OVERRIDE AND OVERLOADING
        // Overide: Only in the derived classes, same name/same parameter list, new version "covers up" inherited one, you can call
        // the inherited one with base. 
        // Overload: Same name, different parameters --> the compiler knows which one can be called by what is specified, all versions
        // readily accesible 

        public override string ToString() 
        {
            return "\n" + name + "\n" + "Hours: " + hours.ToString() + "\nPay rate: " + payRate.ToString("c");
        }
    }
}
