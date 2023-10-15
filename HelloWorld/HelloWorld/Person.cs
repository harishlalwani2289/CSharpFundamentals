


namespace HelloWorld
{
    public class Person
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        public void Introduce() => Console.WriteLine("My name is " + firstName + " " + lastName);
    }

    
}