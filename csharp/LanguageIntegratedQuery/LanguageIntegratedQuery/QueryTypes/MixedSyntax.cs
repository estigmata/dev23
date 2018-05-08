using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery.QueryTypes
{
    public class MixedSyntax
    {
        List<int> numbers1 = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        public void ExecuteQuery1()
        {
            // Using a query expression with method syntax
            // 1, 9, 8, 2, 0 = 5
            int numCount1 =
                (from num in numbers1
                 where num < 3 || num > 7
                 select num).Count();

            Console.WriteLine(numCount1);
        }

        public void ExecuteQuery2()
        {
            // Create a new variable to store the method call result
            IEnumerable<int> numbersQuery =
                from num in numbers1
                where num < 3 || num > 7
                select num;

            int numCount2 = numbersQuery.Count();

            Console.WriteLine(numCount2);
        }
    }
}
