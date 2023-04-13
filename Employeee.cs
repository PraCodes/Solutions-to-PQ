using System;

namespace employeee
{
    class Employeee
    {
       /* public string firstname;
        public string lastname;
        private double salary;
        public Employeee (string fn, string ln, double S)
        {
          firstname = fn;
          lastname = ln;
          Salary = S;
        }
        public double Salary
        {
            get{
                return salary;
            }
            set
            {
                if(value >= 0)
                salary = value; 
            }
        }
        public double Debit(double amount)
        {   if(amount > Salary)
            {
                Console.WriteLine("Opps!The amount entered is greater than {0:C} ", Salary);
            }
            else
            {
                Salary -= amount;
                return Salary;
            }
            return Salary;*/

            public static double reactive()

            {  

                
                
                
                 Console.Write("Enter the value of freq :  ");
                double f = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the value of cap :  ");
                 double c = Convert.ToDouble(Console.ReadLine());

                double reactance = (1) / (2 * Math.PI * f * c);
                
                Console.WriteLine("The reactance is {0}", reactance);

               return reactance;
            }
            
        }
        
    }
