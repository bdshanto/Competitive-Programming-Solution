using System;

namespace ReverseStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string:\n");
            string inputMsg = Console.ReadLine();
            string reverseMsg = "";
            for (int i = inputMsg.Length-1; i >= 0; i--)
            {
                reverseMsg += inputMsg[i];
            }

            Console.WriteLine(reverseMsg);
        }
    }
}
