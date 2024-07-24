using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a prog to find the sum of 10 natural numbers
            int n = 10; // id 10 as 1st natural numbers
            int sum = 0; // currently the sum is empty

            Console.WriteLine("The first 10 natural number is:");
            for(int i = 1; i <= n; i++) // set i to 1 and count to n, if i is less than n then keep counting
            {
                Console.WriteLine(i); // displays the 10 natural numbers
                sum += i; // add each number
            }

            Console.WriteLine($"The Sum is {sum}"); // display sum
            Console.Read();

        }
    }
}
