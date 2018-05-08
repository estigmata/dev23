using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("------");
            WalkingTheDog();
            Console.WriteLine("------");
            WalkingTheDog2();
            Console.WriteLine("------");
            WalkingTheDog3();
            Console.WriteLine("------");*/
            Console.WriteLine(7 + 8 * 3 + 5 % 6 >> 2 << 1);
            Console.WriteLine(64 * 2 >> 3 << 1 + 6 / 2);
            Console.WriteLine(1 | 3 & ~5 | 7 & 9);
            Console.WriteLine(1 | (3 & 5) | 7 & 9);
            Console.WriteLine(1 | 3 & (5 | 7) & 9);
            Console.WriteLine(1 ^ 3 | 5 & 7 | 9 ^ 11 & 13);
            Console.WriteLine(1 ^ ~(3 | 5 & 7) ^ 9);
            Console.WriteLine(1 ^ 3 | 5 | 7 ^ 9);
            Console.WriteLine(~7 & ~2);
            Console.WriteLine(~3 | ~4);
            Console.WriteLine(~(4 | 6));
        }

        public static void WalkingTheDog()
        {
            using (Animal a1 = new Dog())
            {
                a1.Walk();
            }
            Console.WriteLine("Call end");
        }

        public static void WalkingTheDog2()
        {
            using (Dog a1 = new Dog())
            {
                a1.Walk();
            }
            Console.WriteLine("Call end");
        }

        public static void WalkingTheDog3()
        {
            using (Animal a1 = new Animal())
            {
                a1.Walk();
            }
            Console.WriteLine("Call end");
        }
    }

    public class Animal : IDisposable
    {
        public Animal()
        {
            Console.WriteLine("Animal ctor");
        }
        ~Animal()
        {
            Console.WriteLine("Animal destructor");
        }
        public virtual void Walk()
        {
            Console.WriteLine("Animal walk");
        }
        public void Dispose()
        {
            Console.WriteLine("Animal dispose");
            GC.SuppressFinalize(this);
        }
    }

    public class Dog : Animal, IDisposable
    {
        public Dog()
        {
            Console.WriteLine("Dog ctor");
        }
        ~Dog()
        {
            Console.WriteLine("Dog destructor");
        }
        public override void Walk()
        {
            Console.WriteLine("Dog walk");
        }
        public new void Dispose()
        {
            Console.WriteLine("Dog dispose");
        }
    }
}
