using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array__
{
    internal class Program
    {
        /// resevied Array
        static void Main(string[] args)
        {
            Console.Write($"Enter size of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int right = Array.Length - 1;
            int left = 0;
            while (left < right)
            {
                int temp = Array[left];
                Array[left] = Array[right]; 
                Array[right] = temp;
                right--;
                left++;
            }
            Console.Write($"Array is: ");
            for (int y = 0;y < Array.Length;y++)
            {
                
                Console.Write($" {Array[y]} ");
            }
            Console.ReadLine();
        }
    }
}
