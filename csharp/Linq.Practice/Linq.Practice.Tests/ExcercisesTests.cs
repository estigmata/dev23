using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linq.Practice.Managers;
using System.Linq;
using System.Collections.Generic;

namespace Linq.Practice.Tests
{
    [TestClass]
    public class ExcercisesTests
    {
        [TestMethod]
        public void Sample1()
        {
            var pm = new ProductManager();
            var products = pm.GetProductList();

            Assert.AreEqual(77, products.Count);

            // Select all products with price less than 25.0000M.
            var query = products.Where(p => p.UnitPrice < 25.000M);
            var count = 0;

            foreach (var prod in query)
            {
                Console.WriteLine(++count + " - " + prod.UnitPrice);
            }

            Assert.AreEqual(48, query.Count());

            CustomerManager cm = new CustomerManager();
            var customers = cm.GetCustomerList();

            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerID);
            }
        }

        [TestMethod]
        public void Excercise1()
        {
            var productManager = new ProductManager();
            var products = productManager.GetProductList();

            IEnumerable<Model.Product> query =
                from prod in products
                where prod.UnitsInStock == 0
                select prod;

            var count = 0;

            foreach (var p in query)
            {
                Console.WriteLine(++count + ", " + p.ProductName);
            }

            Assert.AreEqual(5, query.Count());
        }

        [TestMethod]
        public void Excercise2()
        {
            var productManager = new ProductManager();
            var products = productManager.GetProductList();

            var query = products.Where(p => p.UnitsInStock > 3);
            var count = 0;

            foreach (var p in query)
            {
                Console.WriteLine(++count + ", " + p.ProductName);
            }

            Assert.AreEqual(71, query.Count());
        }

        [TestMethod]
        public void Excercises3()
        {
            var customersList = new CustomerManager();
            var customers = customersList.GetCustomerList();

            IEnumerable<Model.Customer> query =
                from cust in customers
                where cust.City == "Washington"
                select cust;

            foreach (var c in query)
            {
                foreach (var o in c.Orders)
                {
                    Console.WriteLine("Order: {0}" + o.OrderID);
                    Console.WriteLine("Date: {0}" + o.OrderDate);
                    Console.WriteLine("Total: {0}" + o.Total);
                    Console.WriteLine("=======================");
                }
            }

            Assert.AreEqual(0, query.Count());
        }

        [TestMethod]
        public void Excercises4()
        {
            var customersList = new CustomerManager();
            var customers = customersList.GetCustomerList(); 

            var query = customers.Where(c => 1 == 1).Take(3);

            Assert.AreEqual(3, query.Count());
        }

        [TestMethod]
        public void Excercises5()
        {
            var customersList = new CustomerManager();
            var customers = customersList.GetCustomerList();

            IEnumerable<Model.Customer> query =
                from cust in customers
                where cust.City == "Washington"
                select cust;

            foreach (var c in query)
            {
                IEnumerable<Model.Order> order =
                    (from ord in c.Orders
                     select ord).Take(3);
                foreach (var o in order)
                {
                    Console.WriteLine("Order: {0}" + o.OrderID);
                    Console.WriteLine("Date: {0}" + o.OrderDate);
                    Console.WriteLine("Total: {0}" + o.Total);
                    Console.WriteLine("=======================");
                }
            }

            Assert.AreEqual(0, query.Count());
        }
    }
}
