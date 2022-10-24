using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nextMonth = DateTime.Now.AddMonths(1);
            Console.WriteLine("圖書下個月歸還時間:"+nextMonth);

        }
    }
}
