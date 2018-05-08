using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling.Examples
{
    public class Example2
    {
        public void Method1()
        {
            Method2();
        }

        private void Method2()
        {
            try
            {
                Method3();
            }
            catch (ApplicationException e)
            {
                // Handling the exception
                Console.WriteLine("Logging the exception. [{0}]", e.Message);
            }
            catch (System.Exception e)
            {
                //
            }
        }

        private void Method3()
        {
            var list = new List<string>();

            // Let's imagine that this method is a huge code and in some point the list is set to null
            list = null;

            try
            {
                MethodN(list);
            }
            catch (NullReferenceException e)
            {
                throw new ApplicationException("An app exception was caught because...", e);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        private void MethodN(List<string> list)
        {
            throw new ApplicationException();

            //list.Add("New item");
        }
    }
}
