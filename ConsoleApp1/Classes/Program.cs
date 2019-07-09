using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Money dengi = new Money(1000, 10);
            Console.WriteLine("Общая сумма = " + dengi.totalMoney());
            dengi.checkMoney(20000);
            dengi.defeineQuantity(200);

            //Console.WriteLine(dengi.totalMoney()) ;
            Console.ReadKey();
        }
    }
}
