


using HelloWorld.Math;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(numbers[2]);

            string list = string.Join(",", numbers.Select(x => x+45));
            Console.WriteLine(list);

            string formattedString = string.Format("{0}    {1}", numbers[0], list);
            Console.WriteLine(formattedString);

            string name = "Moshidi";
            Console.WriteLine(name[4]);

            string nameWithBackslash = "Har\\ish";
            Console.WriteLine(nameWithBackslash);

            string path = @"c:\fkfk\dffd\ldkf";
        }


        private static void AddNumber(int number)
        {
            Console.WriteLine(number);
        }
    }

    
}