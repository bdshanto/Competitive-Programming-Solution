using System;
using DateToDayCalculatorApp.Models;
using static System.Console;


namespace DateToDayCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date");
            int year = int.Parse(ReadLine());
            string month = ReadLine();
            int date = int.Parse(ReadLine());


            DateCalculator calculator = new DateCalculator(year,month,date);

            Console.WriteLine(calculator.DayCalculation());
        }
    }
}
