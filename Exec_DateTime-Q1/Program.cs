using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime aftrtThreeDays = DateTime.Now.AddDays(3);
            Console.WriteLine("三天後DVD應歸還時間:"+ aftrtThreeDays.ToString());
        }
    }
}
