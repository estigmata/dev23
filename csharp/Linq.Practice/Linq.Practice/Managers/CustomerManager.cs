using Linq.Practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq.Practice.Managers
{
    public class CustomerManager
    {
        private List<Customer> customerList;

        public List<Customer> GetCustomerList()
        {
            if (customerList == null)
            {
                customerList = (
                    from e in XDocument.Load("Customers.xml").
                              Root.Elements("customer")
                    select new Customer
                    {
                        CustomerID = (string)e.Element("id"),
                        CompanyName = (string)e.Element("name"),
                        Address = (string)e.Element("address"),
                        City = (string)e.Element("city"),
                        Region = (string)e.Element("region"),
                        PostalCode = (string)e.Element("postalcode"),
                        Country = (string)e.Element("country"),
                        Phone = (string)e.Element("phone"),
                        Fax = (string)e.Element("fax"),
                        Orders = (
                            from o in e.Elements("orders").Elements("order")
                            select new Order
                            {
                                OrderID = (int)o.Element("id"),
                                OrderDate = (DateTime)o.Element("orderdate"),
                                Total = (decimal)o.Element("total")
                            })
                            .ToArray()
                    })
                    .ToList();
            }

            return customerList;
        }
    }
}
