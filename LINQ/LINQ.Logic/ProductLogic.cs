using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Entities;

namespace LINQ.Logic
{
    public class ProductLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public List<Products> GetById(int id)
        {
            return _context.Products.Where(p => p.ProductID == id).ToList();
        }

        public List<Products> SinStock()
        {
            return _context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }

        public List<Products> PrecioMayorA3()
        {
            return _context.Products.Where(p => p.UnitPrice >= 3)
                                    .Where(p => p.UnitsInStock>0).ToList();
        }

        public Products PrimeroEncontrado(int id)
        {
            try
            {
                return _context.Products.FirstOrDefault(p => p.ProductID == id);
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Products> GetAllPorNombre()
        {
            return (from Products in _context.Products
                    orderby Products.ProductName ascending
                    select Products).ToList();
        }

        public List<Products> GetAllPorStock()
        {
            return (from Products in _context.Products
                    orderby Products.UnitsInStock descending
                    select Products).ToList();
        }

        public List<String> ProductoXCategoria()
        {
            List<String> tmpList = new List<String>();
            var query = (from Products in _context.Products
                         join Categories in _context.Categories
                         on Products.CategoryID equals Categories.CategoryID
                         select new { Products.ProductID , Products.ProductName, Categories.CategoryName
                         });

            foreach (var item in query)
            {
                tmpList.Add($"ID: {item.ProductID} , Producto: {item.ProductName} , Categoria: {item.CategoryName}");
            }
            return tmpList;
        }

        public Products PrimerProducto(List<Products> lista)
        {
            return lista.First();
        }
    }
}
