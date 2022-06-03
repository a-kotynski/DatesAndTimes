using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString()); //doesn't show time
            //Console.WriteLine(myValue.ToShortTimeString()); //just time of day
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            /* my code to write long date and long time in one line
            string myDateFull = myValue.ToLongDateString();
            string myTimeFull = myValue.ToLongTimeString();

            Console.WriteLine("{0}" + " " + "{1}", myDateFull, myTimeFull);
            */


            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); //adds 3 days to current day
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBrithday = new DateTime(1333, 4, 25);
            //Console.WriteLine(myBrithday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("25/4/1333"); //is Parse DD/MM/YYY or MM/DD/YYYY
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);   
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}