using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime lastDay = DateTime.Now.AddMonths(1).AddDays(-DateTime.Now.AddMonths(1).Day);

            Console.WriteLine(lastDay);
        }
    }
}
