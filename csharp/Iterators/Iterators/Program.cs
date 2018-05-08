namespace Iterators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in SomeNumbers())
            {
                Console.Write(number.ToString() + " ");
            }

            // Output: 3 5 8
            Console.ReadKey();

        }

        /// <summary>
        /// This is a iterator method
        /// </summary>
        /// <returns>Returns an iterator object</returns>
        public static IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 8;
        }
    }
}
