using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_9_Ejercicio_55
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[] { 100, 2, 53, 23, 34, 21, 16, 74, 89, 12, 1 };
            int[] vector2 = new int[] { 200, 33, 3, 24, 114, 121, 346, 555, 19, 122, 11 };
            int j;

            int[] vector3 = new int[vector1.Length + vector2.Length];

            for(int i=0; i!= vector1.Length;i++)
            {
                vector3[i] = vector1[i];
            }

           j = vector1.Length;
            
            for(int i=0;i!=vector2.Length;i++)
            {
                vector3[j] = vector2[i];
                j++;
            }


            Array.Sort(vector3);
            for (int i = 0;i!= vector3.Length; i++)
            {
                Console.Write("{0}, ",vector3[i]);
            }

            Console.ReadKey();

        }
    }
}
