using System;
using System.Collections.Generic;
using System.Linq;

namespace DateToDayCalculatorApp.Models
{
    public class DateCalculator
    {
        public DateCalculator(int year, string monthName, int date)
        {
            Year = year;
            MonthName = monthName;
            Date = date;
         
        }
        private int Year { get; set; }
        private string MonthName { get; set; }
        private int Date { get; set; }
    





        //check lip year

        public bool LipYear()
        {
            if (this.Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            {
                return true;
            }
            return false;
        }
        //

        WeekDays w = new WeekDays();
        Months m = new Months(); 
        //Calculation
        public string DayCalculation()
        {
            int yearCode = 0;
            //month
            foreach (var month in m.monthName)
            {
                if (month.Value == MonthName)
                {
                    yearCode = month.Key;
                }
            }

            /*if (Year! >= 1900)
            {
                return;
            }*/
            string dayName = "";
            int currentYear = Year - 1900;
            currentYear = currentYear + (currentYear / 4) + Date + yearCode;
            int today = currentYear / 7;

            foreach (var day in w.days)
            {
                if (day.Key==today)
                {
                    dayName = day.Value;
                }

            }

            return dayName;

        }


    }
}