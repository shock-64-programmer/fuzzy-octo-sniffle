using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[] { 5, 8, 3, 20, 11, 1, 0, 6, 13, 12 };
            Console.WriteLine();
            for (int j = 0; j < a.Length; j++)
                Console.WriteLine(a[j]+" ");
            Console.WriteLine();
            int    max = 0;
            for (int i = 0; i < a.Length-1; i++)
               
            {
                if (a[i] > max)
                    max = a[i];
            } 
            Console.WriteLine(max);
        }    
    }
}
