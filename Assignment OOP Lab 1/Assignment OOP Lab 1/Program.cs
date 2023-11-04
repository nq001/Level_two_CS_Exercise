using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace swap_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int First_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int number = 0;  

            number = First_number;
            First_number = second_number;
            second_number= number;

            Console.WriteLine("the first number: {0} \nthe second number: {1}", First_number , second_number);
            Console.ReadKey();

        }
    }
}
