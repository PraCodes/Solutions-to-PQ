
using System;

namespace Date
{
    class Date

    {
     public int month{ get; set; }
     public int day{ get; set; }
     public int year{ get; set; }

     
     public Date(int m, int d, int y)
     {
      month = m;
      day = d;
      year = y;
     }
     
     
     public void DisplayDate ()
     {
        Console.WriteLine("Welcome nasif. Todays date is{0}/{1}/{2}", day,month,year);
     }


      
    }
}
