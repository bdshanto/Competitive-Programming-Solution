using System.Collections.Generic;

namespace DateToDayCalculatorApp.Models
{
    public class Months
    {
        public IDictionary<int, string> monthName = new Dictionary<int, string>()
        {
            {1, "January"},
            {4,"february" },
            {4,"March" },
            {0,"April" },
            {2,"May" },
            {5,"June" },
            {0,"July" },
            {3,"August" },
            {6,"September" },
            {1,"October" },
            {4,"November" },
            {6,"December" }
        };
    }
}