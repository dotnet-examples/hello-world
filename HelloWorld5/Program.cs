// The simplist helloworld application,
// with async / await support.

namespace HelloWorld5;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Hello, World!");

        await Task.CompletedTask;
    }
}