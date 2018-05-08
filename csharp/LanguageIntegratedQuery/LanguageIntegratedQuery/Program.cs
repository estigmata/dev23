using LanguageIntegratedQuery.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = new Operations();

            //operations.ObtainDataSource();
            //operations.FilterByEnabledStudents();
            //operations.OrderByName();
            //operations.GroupByEnabled();
            //operations.GroupByEnabledMoreThan3();
            operations.JoinStudentAndTeacher();
        }
    }
}
