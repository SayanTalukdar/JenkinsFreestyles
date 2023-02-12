using System;
using System.Threading.Tasks;
//using Microsoft.Extensions.Logging;

namespace Jenkins_FreeStyle_Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            Console.WriteLine("Counter starts from here:");
            while (max == -1 || counter < max)
            {
                Console.WriteLine($"Counter number: {++counter}");
                await Task.Delay(1000);
            }

        }
    }
}
