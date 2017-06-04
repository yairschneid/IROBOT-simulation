using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // ... This takes 10 seconds to finish.
        for (int i = 0; i < 1000; i++)
        {
            System.Threading.Thread.Sleep(10);
        }

        // Stop.
        stopwatch.Stop();

        // Write hours, minutes and seconds.
        Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        Console.ReadLine();
    }
}
