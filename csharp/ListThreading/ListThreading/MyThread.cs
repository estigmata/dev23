using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListThreading
{
    class MyThread
    {
        private List<int> TheList;
        private List<int> NewList;
        private List<int> Blacklist;

        private Action<List<int>> callback;

        public MyThread(List<int> list, ref List<int> container, Action<List<int>> callbackDelegate)
        {
            this.TheList = list;
            this.NewList = container;
            this.Blacklist = new List<int>();
            this.callback = callbackDelegate;
        }

        public void Compare()
        {
            /*try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadAbortException ae)
            {
                Console.WriteLine("--> {0}", ae);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }*/
            
            foreach (int element in this.TheList)
            {
                if (this.NewList.Exists(x => x == element))
                    this.Blacklist.Add(element);
                else
                    lock(Program.lockObject)
                    {
                        this.NewList.Add(element);
                    }
            }

            this.callback.Invoke(NewList);
        }
    }
}
