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
            Console.WriteLine("Hello World!");
            byte number = 253;
            float price = 20.54f;
            char character = '$';
            string name = "Harish";
            bool isAdmin = false;
            bool isGuest = false;
            int n = 0;
            char character1 = 'a';
            char character2 = 'b';

            Console.WriteLine(number);
            Console.WriteLine(price);
            Console.WriteLine(character2);
            Console.WriteLine(name);
            Console.WriteLine(isAdmin);
            Console.WriteLine(price.ToString() + " " + n.ToString());
            Console.WriteLine(n);
            Console.WriteLine(character1);
            Console.WriteLine(character);
        }
    }
}