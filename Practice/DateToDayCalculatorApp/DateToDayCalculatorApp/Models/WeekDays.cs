using System.Collections.Generic;

namespace DateToDayCalculatorApp.Models
{
    public class WeekDays
    {
     public   IDictionary<int,string> days= new Dictionary<int, string>()
        {
            {0,"Saturday" },
            {1,"Sunday" },
            {2,"Monday" },
            {3,"Tuesday" },
            {4,"Wednesday" },
            {5,"Thursday" },
            {6,"Friday" },
        };
        
    }
}