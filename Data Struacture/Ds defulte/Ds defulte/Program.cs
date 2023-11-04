using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds_defulte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Read size and bulid Array
            Console.Write("Enter size of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[size];

            int i = 0;
            while (i < size)
            {
                Console.Write("Enter a number: ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            /// print Original Array
            Console.WriteLine("Original Array: ");
            for (int m = 0; m < Arr.Length; m++)
            {
                Console.WriteLine(Arr[m]);
            }

            /// ask about operation if it Addition as a or  Delete as d
            Console.Write("Enter operation Add press a or Del press d: ");
            string ask = Console.ReadLine();
            switch (ask)  /// used switch rather if condition 
            {
                /// Addition operation
                case "a":

                    /// build new Array as same length from first array + 1
                    int[] Addarr = new int[Arr.Length + 1];

                    Console.Write("Enter value: ");
                    int x = Convert.ToInt32(Console.ReadLine()); /// x is value that insert from user
                                                                  
                    Console.WriteLine("Enter position: "); /// ask about position and value to add
                    int pos = Convert.ToInt32(Console.ReadLine());

                    /// condition if position more than Array size or less than zero 
                    if (pos > Addarr.Length || pos < 0)
                    {
                        Console.WriteLine("this position more than the size of Array or position less than zero");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        /// processing 
                        for (int j = 0, m = 0; j < Addarr.Length; j++) /// init j mean index and m mean item
                        {
                            if (j == pos)
                            {
                                Addarr[j] = x;
                            }
                            else
                            {
                                Addarr[j] = Arr[m];
                                m++;
                            }
                        }
                        /// print Array after Addition
                        Console.WriteLine("Array after Addition: ");
                        for (int l = 0; l < Addarr.Length; l++)
                        {
                            Console.WriteLine(Addarr[l]);
                        }                     
                    }
                    Console.ReadKey();
                    break;

                /// Delete operation
                case "d":
                    int[] Delarr = new int[Arr.Length - 1];
                    Console.Write("Enter position: ");
                    int posit = Convert.ToInt32(Console.ReadLine());

                    if (posit > Arr.Length || posit < 0)
                    {
                        Console.WriteLine("this position more than the size of Array or position less than zero");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        /// processing
                        for (int j = 0, s = 0; j < Arr.Length; j++)
                        {
                            if (j != posit)
                            {
                                Delarr[s] = Arr[j];
                                s++;
                            }
                        }
                    }
                    /// print Array after delete
                    Console.WriteLine("Array after delete!");
                    for (int k = 0; k < Delarr.Length; k++)
                    {
                        Console.WriteLine(Delarr[k]);
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("we have not this operation try again!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
