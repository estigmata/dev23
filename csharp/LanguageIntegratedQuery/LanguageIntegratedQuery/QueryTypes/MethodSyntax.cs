using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery.QueryTypes
{
    public class MethodSyntax
    {
        List<int> numbers1 = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        List<int> numbers2 = new List<int>() { 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 };

        public void ExecuteQuery1()
        {
            double average = numbers1.Average();
            Console.WriteLine(average);
        }

        public void ExecuteQuery2()
        {
            IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);

            foreach (var item in concatenationQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void ExecuteQuery3()
        {
            // If the method has Action or Func parameters, these are provided in the form of a lambda expression.
            IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);

            foreach (var item in largeNumbersQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
