/* 
Hunter Clezie 
Spring 2026
RCET2265
Console Practice program
github url: https://github.com/hunterclezie-pixel/SayMyName.git
*/
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
