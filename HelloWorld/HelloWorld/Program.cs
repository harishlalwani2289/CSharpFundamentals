


using HelloWorld.Math;

namespace HelloWorld
{
    enum ShippingMethod
    {
        RegularMail = 0,
        RegisteredAirMail = 1,
        ExpressMail = 2,
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b += 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));

            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 111;
            Console.WriteLine(array1[0]);
        }


        private static void AddNumber(int number)
        {
            Console.WriteLine(number);
        }
    }

    
}