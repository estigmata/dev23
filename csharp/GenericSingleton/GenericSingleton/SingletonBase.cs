using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingleton
{
    public class SingletonBase<T> where T : SingletonBase<T>
    {
        private static object lockingObject = new object();

        private static T singletonObject;

        protected SingletonBase()
        {
        }

        public static T Instance
        {
            get
            {
                if (singletonObject == null)
                {
                    lock (lockingObject)
                    {
                        if (singletonObject == null)
                        {
                            singletonObject = (T)Activator.CreateInstance(typeof(T), true);
                        }
                    }
                }

                return singletonObject;
            }
        }
    }
}
