using System.Globalization;
using System;

namespace EMPLOYEE
{
    class employee
    // instance variable
    { public string firstname;
      public string lastname;
      private decimal salary;
     // constructors
      public employee (string fn, string ln, decimal mySalary)
        {
            firstname = fn;
            lastname = ln;
            Salary  = mySalary;
        }
        //auto-implemented props.for validation
        public decimal Salary
        {
            get{
                return salary;
            }
            set
            {
                if (value >= 0)
                salary = value;
            }
        }

        public void oneTenth(decimal amount)
        {
            Salary = Salary + amount;
        }

    }
}
