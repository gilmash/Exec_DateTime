using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("請輸入年分,例如2022:");
            string input = Console.ReadLine();

            int year = Convert.ToInt32(input);

                        
            DateTime firstDay = new DateTime(year, 1, 1);

            
            DateTime firstSunDay = firstDay;
            int weekday = (int)firstDay.DayOfWeek;


           
            if (weekday > 0)
            {
                firstSunDay = firstDay.AddDays(7 - weekday);
            }
            

            DateTime endDay = new DateTime(year, 12, 31);
            for (DateTime i = firstSunDay; i <= endDay; i = i.AddDays(7))
            {
                Console.WriteLine(i.ToString("yyyy/MM/dd"));
            }
        }
    }
}
