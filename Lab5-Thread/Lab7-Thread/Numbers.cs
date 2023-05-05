using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Thread
{
    internal class Numbers
    {

        public static void even(int[] Arr)
        {
            int sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (i % 2 == 0)
                { sum += Arr[i]; }

            }
            Console.WriteLine("sum even is :" + sum);
        }

        public static void odd(int[] Arr)
        {
            int sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {

                if (i % 2 != 0)
                { sum += Arr[i]; }
            }
            Console.WriteLine("sum odd is :" + sum);
        }
    }
}
