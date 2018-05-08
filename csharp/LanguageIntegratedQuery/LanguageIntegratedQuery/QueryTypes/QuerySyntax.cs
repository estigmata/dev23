using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery.QueryTypes
{
    public class QuerySyntax
    {
        private List<int> numbers;

        public QuerySyntax()
        {
            numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        }

        public IEnumerable<int> GetQuery1()
        {
            // The query variable can also be implicitly typed by using var
            IEnumerable<int> filteringQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;

            return filteringQuery;
        }

        public IEnumerable<int> GetQuery2()
        {
            IEnumerable<int> orderingQuery =
                from num in numbers
                where num < 3 || num > 7
                orderby num ascending
                select num;

            return orderingQuery;
        }
    }
}
