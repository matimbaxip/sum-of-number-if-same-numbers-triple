using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_number_if_same_numbers_triple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numerical values:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


            int sum = num1 + num2;

            if (num1 == num2)
            {
                sum *= 3;

            }

            Console.WriteLine("The computed sum is: " + sum);
            Console.ReadLine(); 
        }
    }
}
