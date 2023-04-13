using System;

namespace MILES
{
    class Miles
    {
        static void Main(string[] args)
        {
            try{
                Console.Write("Enter value for the miles driven  ");
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter value for the gallon  ");
                double gallon =Convert.ToDouble(Console.ReadLine());
                double milesPergallon;
                milesPergallon = (miles / gallon);
                Console.WriteLine("The miles per gallon is {0} ", milesPergallon);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
