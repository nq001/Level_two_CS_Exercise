using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a number: ");
            int pnum = int.Parse(Console.ReadLine());
            if (primenum(pnum))
            {
                Console.WriteLine($"{pnum} this is a prime number! ");
            }
            else
            {
                Console.WriteLine($"{pnum} this is not a prime number! ");
            }
            Console.ReadLine();

        }
        public static bool primenum(int num)
        {
           if (num <= 1)
           {
                return false;
           }

           for (int i = 2; i <= num/2; i++)
           {
                
                if (num % i == 0)
                {
                    return false;
                }
           }
           return true;
        }
        
    }

}
