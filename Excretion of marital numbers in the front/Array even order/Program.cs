using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_even_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter size of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[size];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int ri = Arr.Length -1;
            int lf = 0;
            while (lf < ri)
            {
                while (Arr[lf] % 2 == 0 && lf < ri)
                {
                    lf++;
                }
                while (Arr[ri] % 2 != 0 && lf < ri)
                {
                    ri--;
                }

                if(lf < ri)
                {
                    int temp = Arr[lf];
                    Arr[lf] = Arr[ri];
                    Arr[ri] = temp;
                }
            }
            Console.Write($"Array is: ");
            for(int f = 0; f < Arr.Length;f++)
            {
                Console.Write( Arr[f] );
            }
            Console.ReadKey();
        }
    }
}
