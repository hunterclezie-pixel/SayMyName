namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, what is your name?");
            string userinput = "Insert name";
            userinput = Console.ReadLine();
            Console.WriteLine($"It's nice to meet you,\"{userinput}\"");
            Console.Read();
        }
    }
}
