using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ItemCountInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 1, 2, 2, 3, 3, 4, 4, 5 };

            List<int> list = new List<int>();

             
            for (int i = 0; i < input.Length; i++)
            {
                if (!list.Contains(input[i]))
                {
                    list.Add(input[i]);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }



        }
    }
}
