using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB.EF.Entities;
using LAB.EF.Data;

namespace LAB.EF.Logic
{
    public class ClientesLogic : BaseLogic, IABMLogic<Customers>
    {
        public ClientesLogic() { }

        public ClientesLogic(NorthwindContext context)
        {
            _context = context;
        }

        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customers GetById(string id)
        {
           return _context.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public void Add(Customers newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            try
            {
                var aEliminar = _context.Customers.Find(id);
                _context.Customers.Remove(aEliminar);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Update(Customers toUpdate)
        {
            var clienteUpdate = _context.Customers.Find(toUpdate.CustomerID);
            clienteUpdate.CompanyName = toUpdate.CompanyName;
            clienteUpdate.City = toUpdate.City;
            _context.SaveChanges();
        }
    }
}
