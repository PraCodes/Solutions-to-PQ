using System;

namespace EMPLOYEE
{
    class employeetest
    {
        static void Main(string[] args)
        {
           employee ep = new employee("moyosore", "nasif", 50.003M);
           Console.WriteLine("Welcome {0} {1}, your account balance is: {2:C}", ep.firstname, ep.lastname, ep.Salary ); 

           Console.Write("Enter 10% value of Salary");
           decimal amount = Convert.ToDecimal(Console.ReadLine());

            ep.oneTenth(amount);

           Console.WriteLine("Your new salary is: {0:C}", ep.Salary);
        }
    }
}
