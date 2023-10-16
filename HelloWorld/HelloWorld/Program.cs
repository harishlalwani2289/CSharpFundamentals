


using HelloWorld.Math;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            var firstName = "Mosh";
            var lastName = "Hypol";

            var fullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            var names = new string[3] { "John", "Jaani", "Janardan" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);


        }


        private static void AddNumber(int number)
        {
            Console.WriteLine(number);
        }
    }

    
}