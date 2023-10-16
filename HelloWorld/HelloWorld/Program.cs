


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
            var method = ShippingMethod.RegularMail;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "ExpressMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod.ToString());
        }


        private static void AddNumber(int number)
        {
            Console.WriteLine(number);
        }
    }

    
}