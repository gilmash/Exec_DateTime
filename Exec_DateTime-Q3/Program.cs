using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime firstday = new DateTime(DateTime.Now.Year, DateTime.Now.Month,1);
            Console.WriteLine(firstday);
        }
    }
}
