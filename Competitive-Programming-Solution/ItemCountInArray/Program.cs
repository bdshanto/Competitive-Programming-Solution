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
            string[] arr = {"1", "1", "2", "2", "2", "3", "3", "4", "5", "5", "4", "5", "6","7"};

            List<string> arrTemp =new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (  !arrTemp.Contains(arr[i]) )
                    {
                        /*Console.WriteLine(arr[i]);*/

                        arrTemp.Add(arr[j]);

                    }
                }
            }

            foreach (var item in arrTemp)
            {
                Console.WriteLine(item);
                
            }
        }
          
    }
}
