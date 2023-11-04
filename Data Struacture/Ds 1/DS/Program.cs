using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[size];
            Console.Write("Enter a number: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a number: ", Arr[i] = Convert.ToInt32(Console.ReadLine()));
                ///Arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }

            /// to ask user give item to show index
            Console.Write("Enter a number to search index: ");
            int num = Convert.ToInt32((Console.ReadLine()));

            int index = 5;
            for (int n = 0;n < Arr.Length; n++)
            {
                if (Arr[n] == num)
                {
                    index = n;
                    break;
                }

            }
            if (index != 5)
            {
                Console.WriteLine("the index of this value is: {0}", index);
            }
            else
            {
                Console.WriteLine("sorry but this value not found in Array");
            }
            Console.ReadKey();
        }
    }
}
