using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Program
    {
        static int Fib(int n)
        {
            if (n <= 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
              Console.WriteLine("add: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("fib");

        for (int i = 1; i <= n; i++)
            Console.Write(Fib(i) + " ");
        Console.ReadKey();
    
        }
    }
}
