using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Entities;


namespace LINQ.Logic
{
    public class CustomerLogic : BaseLogic
    {
        public Customers DevolverCustomer()
        {
            return _context.Customers.FirstOrDefault();
        }

        public List<string> GetUpperAndLower()
        {
            return _context.Customers.Select(c => c.ContactName.ToUpper())
                .Concat(_context.Customers.Select(c2 => c2.ContactName.ToLower())).ToList();
        }


        public List<Customers> FiltrarPorRegion(string region)
        {
            return _context.Customers.Where(c => c.Region == region).ToList();
        }

        public List<String> NombreCustomers()
        {
            return _context.Customers.Select(c => c.ContactName).ToList();
        }


        public List<string> JoinConOrders()
        {
            List<string> tmpList = new List<string>();
            DateTime a = new DateTime(01/01/1997);

            var Query = from Customers in _context.Customers
                        join Orders in _context.Orders
                        on Customers.CustomerID equals Orders.CustomerID

                        where Customers.Region == "WA" && Orders.OrderDate.Value.Year >= 1997
                        select new
                        {
                            Customers.ContactName,
                            Customers.Region,
                            Orders.OrderDate
                        };


            foreach (var item in Query)
            {
                tmpList.Add($"Nombre: {item.ContactName}, Region: {item.Region} , Fecha: {item.OrderDate}");
            }

            return tmpList;

        }

        public List<Customers> Top3Region (string region)
        {
            return (from Customers in _context.Customers
                        where Customers.Region == region
                        select  Customers).Take(3).ToList();
        }


    }
}
