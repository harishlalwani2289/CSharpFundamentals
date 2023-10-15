


using HelloWorld.Math;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var john = new Person
                {
                    firstName = "John",
                    lastName = "Smith"
                };
                john.Introduce();

            }
            catch (OverflowException e)
            {
                Console.WriteLine("Kya kar rahe ho bhai..");
                //throw e;
            }

            Calculator calculator = new Calculator();
            Console.WriteLine( calculator.add(3, 4));

        }

        private static void AddNumber(int number)
        {
            Console.WriteLine(number);
        }
    }

    
}