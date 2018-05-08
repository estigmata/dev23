namespace UsingIterators
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> months = new List<string>();

            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");

            IEnumerable<string> enumerableOfString = (IEnumerable<string>)months;

            foreach (string month in enumerableOfString)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine();
            
            IEnumerator<string> enumeratorOfString = months.GetEnumerator();

            while (enumeratorOfString.MoveNext())
            {
                Console.WriteLine(enumeratorOfString.Current);
            }

            Console.WriteLine();
            
            EnumeratorMethodOne(months.GetEnumerator());
        }

        static void EnumeratorMethodOne(IEnumerator<string> monthsEnumerator)
        {
            while (monthsEnumerator.MoveNext())
            {
                Console.WriteLine(monthsEnumerator.Current);

                if (monthsEnumerator.Current == "June")
                {
                    EnumeratorMethodTwo(monthsEnumerator);
                }
            }
        }

        static void EnumeratorMethodTwo(IEnumerator<string> monthsEnumerator)
        {
            while (monthsEnumerator.MoveNext())
            {
                Console.WriteLine(monthsEnumerator.Current);
            }
        }
    }
}
