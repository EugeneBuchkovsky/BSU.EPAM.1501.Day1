using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSU.EPAM._1501.Day1.Bychkovksy.Task1;

namespace BSU.EPAM._1501.Day1.Bychkovsky.Task1Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Root of 2-th degree of 49 with Math.Pow = " + Math.Pow(49, 0.5));
            Console.WriteLine("Root of 2-th degree of 49 with Newton's method =" + Method.Newton(49, 2));

            Console.WriteLine("Root of 4-th degree of 20 with Math.Pow =  " + Math.Pow(20, 0.25));
            Console.WriteLine("Root of 4-th degree of 49 with Newton's method  " + Method.Newton(20, 4));

            Console.WriteLine("Root of 5-th degree of 100 with Math.Pow =  " + Math.Pow(100, 0.2));
            Console.WriteLine("Root of 5-th degree of 100 with Newton's method  " + Method.Newton(100, 5));

            Console.ReadLine();
        }
    }
}
