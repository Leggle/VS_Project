using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reverse String
            string str = "spring";
            StringBuilder stb = new StringBuilder();
            Console.WriteLine("original string is {0}.", str);

            for (int i = str.Length - 1; i>=0; i--)
            {
                stb.Append(str[i]);
            }

            Console.WriteLine("Reverse string is {0}.", stb);
            Console.WriteLine();


            // Arrays
            int[] a = { 3, 4, 5, 1, -1 };
            for(int i=0; i<a.Length; i++)
            {
                if(a[i] < 0)
                {
                    Console.WriteLine("{0}, Meet negative number, stopped", a[i]);
                    break;
                }
                else if(a[i] >= a.Length)
                {
                    Console.WriteLine("Out of Boundry, stopped");
                    break;
                }
                else if(0 <= a[i] && a[i] < a.Length)
                {
                    if(a[i] == i)
                    {
                        Console.WriteLine("Index equals value, stopped");
                        break;
                    }
                    else
                    {
                        i = a[i] - 1;
                        Console.WriteLine(i+1);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
