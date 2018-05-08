namespace UsingIterators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyEnumerable : IEnumerable<string>
    {
        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private IEnumerator<string> GetEnumerator()
        {
            yield return "string";
        }
    }
}
