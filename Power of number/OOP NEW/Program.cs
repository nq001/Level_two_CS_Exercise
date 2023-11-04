using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_number

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter basic number: ");
            int basic = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter power number: ");
            int power = Convert.ToInt32(Console.ReadLine());
            int expo = power_num(basic, power);
            Console.WriteLine($"Result is {expo}");
            Console.ReadLine();

        }
        static int power_num(int num_basic, int num_power)
        {
            int result = 1;
            for (int i = 0; i < num_power; i++)
            {
                result *= num_basic;
            }
            return result;
        }
    }
}
