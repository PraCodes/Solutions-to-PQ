using System;

namespace employeee
{
    class Employeeetest
    {
        static void Main(string[] args)
        {
            /*Employeee Ep = new Employeee("Mosidat", "Ajakore", 1000.00 );
            Console.WriteLine("Welcome {0} {1}, your account balance is {2:c} ", Ep.firstname, Ep.lastname, Ep.Salary);

            Console.Write("Enter the amount to be debited from your salary:   ");
            double aMount = Convert.ToDouble(Console.ReadLine());

            Ep.Debit(aMount);

            Console.WriteLine("Your new salary is {0:C}", Ep.Salary);*/

            Employeee.reactive();
        }
    }
}
