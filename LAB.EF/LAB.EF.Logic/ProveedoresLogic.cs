using LAB.EF.Data;
using LAB.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.EF.Logic
{
    public class ProveedoresLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public void Add(Suppliers toAdd)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var aEliminar = _context.Suppliers.Find(id);
            _context.Suppliers.Remove(aEliminar);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public List<Suppliers> GetById(string id)
        {
            return _context.Suppliers.Where(s => s.SupplierID == Convert.ToInt32(id)).ToList();
        }

        public void Update(Suppliers toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
