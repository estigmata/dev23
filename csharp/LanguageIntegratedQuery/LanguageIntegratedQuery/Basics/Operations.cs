using LanguageIntegratedQuery.Basics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery.Basics
{
    public class Operations
    {
        private List<Student> Students { get; set; }

        private List<Teacher> Teachers { get; set; }

        public Operations()
        {
            Students = new List<Student>()
            {
                new Student() { Name = "Juan", Age = 15, Enabled = true },
                new Student() { Name = "Jose", Age = 18, Enabled = true },
                new Student() { Name = "Maria", Age = 17, Enabled = false },
                new Student() { Name = "Pepe", Age = 22, Enabled = true },
                new Student() { Name = "Oscar", Age = 25, Enabled = false },
                new Student() { Name = "Bart", Age = 20, Enabled = false },
                new Student() { Name = "Liza", Age = 20, Enabled = false }
            };

            Teachers = new List<Teacher>()
            {
                new Teacher() { Name = "Teacher1", Enabled = true },
                new Teacher() { Name = "TeacherA", Enabled = true },
                new Teacher() { Name = "Teacher100", Enabled = false }
            };
        }

        /// <summary>
        /// Example: Obtaining data source
        /// 'from' clause
        /// </summary>
        public void ObtainDataSource()
        {
            var queryAllStudents = from student in Students
                                   select student;

            foreach (var student in queryAllStudents)
            {
                Console.WriteLine(student.Name);
            }
        }

        /// <summary>
        /// Example: Filtering
        /// 'where' clause
        /// </summary>
        public void FilterByEnabledStudents()
        {
            var queryByEnabled = from student in Students
                                 where student.Enabled
                                 select student;

            foreach (var student in queryByEnabled)
            {
                Console.WriteLine(student.Name);
            }
        }

        /// <summary>
        /// Example: Ordering
        /// 'orderby' clause
        /// </summary>
        public void OrderByName()
        {
            var queryOrderedByName = from student in Students
                                     orderby student.Name
                                     select student;

            foreach (var student in queryOrderedByName)
            {
                Console.WriteLine(student.Name);
            }
        }

        /// <summary>
        /// Example: Grouping
        /// 'group' clause
        /// </summary>
        public void GroupByEnabled()
        {
            // queryGroupByEnabled is an IEnumerable<IGrouping<bool, Student>>
            var queryGroupByEnabled = from student in Students
                                    group student by student.Enabled;

            // studentGroup is an IGrouping<bool, Student>
            foreach (var studentGroup in queryGroupByEnabled)
            {
                Console.WriteLine(studentGroup.Key);

                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("\t{0}", student.Name);
                }
            }
        }

        public void GroupByEnabledMoreThan3()
        {
            // queryGroupByEnabled is an IEnumerable<IGrouping<bool, Student>>
            var queryGroupByEnabled = from student in Students
                                      group student by student.Enabled into sGroup
                                      where sGroup.Count() > 3
                                      select sGroup;

            // studentGroup is an IGrouping<bool, Student>
            foreach (var studentGroup in queryGroupByEnabled)
            {
                Console.WriteLine(studentGroup.Key);

                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("\t{0}", student.Name);
                }
            }
        }

        public void JoinStudentAndTeacher()
        {
            var innerJoinQuery = from student in Students
                                 where student.Enabled
                                 join teacher in Teachers on student.Enabled equals teacher.Enabled
                                 select new { StudentName = student.Name, TeacherName = teacher.Name };

            foreach (var person in innerJoinQuery)
            {
                Console.WriteLine("{0} | {1}", person.StudentName, person.TeacherName);
            }
        }
    }
}
