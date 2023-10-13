using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);
            Console.WriteLine("{0} {1}", int.MaxValue, int.MinValue);
            Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);
            Console.WriteLine("{0} {1}", double.MaxValue, double.MinValue);
        }
    }
}