// read the args.

namespace HelloWorld4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("args count: " + args.Length);
        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }
        Console.WriteLine("Hello, World!");
    }
}