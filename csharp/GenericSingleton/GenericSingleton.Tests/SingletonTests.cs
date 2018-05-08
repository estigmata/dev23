using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericSingleton.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void DerivedSingletonTest()
        {
            var derivedSingleton = DerivedSingleton.Instance;
            derivedSingleton.MyProperty = 10;
            Assert.AreEqual(10, derivedSingleton.MyProperty);
            
            var derivedSingleton2 = DerivedSingleton.Instance;
            Assert.AreEqual(10, derivedSingleton2.MyProperty);
        }

        class MyOtherDerivedSingletonClass : SingletonBase<MyOtherDerivedSingletonClass>
        {
            private MyOtherDerivedSingletonClass()
            {
            }

            public int MyProperty { get; set; }
        }

        [TestMethod]
        public void BaseSingletonTest()
        {
            var singletonBase = SingletonBase<MyOtherDerivedSingletonClass>.Instance;
            singletonBase.MyProperty = 15;
            Assert.AreEqual(15, singletonBase.MyProperty);

            var singletonBase2 = SingletonBase<MyOtherDerivedSingletonClass>.Instance;
            Assert.AreEqual(15, singletonBase2.MyProperty);
        }

        [TestMethod]
        public void BaseSingletonTestNewInstance()
        {
            // Uncomment the following line and you will see that the default constructor is not accessible
            //var singletonBase = new SingletonBase<MyClass>();
        }

        [TestMethod]
        public void DerivedSingletonTestNewInstance()
        {
            // Uncomment the following line and you will see that the default constructor is not accessible
            //var derivedSingleton = new DerivedSingleton();
        }
    }
}
