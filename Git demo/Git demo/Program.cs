using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine(sum);

            int diff = Math.Abs(a-b);
            Console.WriteLine(diff);

            int product = a * b;
            Console.WriteLine(product);


        }
    }
}
