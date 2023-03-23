using LAB.EF.Entities;
using LAB.EF.Logic;
using LAB.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB.EF.MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            ClientesLogic clogic = new ClientesLogic();
            List<CustomerViewModel> result = clogic.GetAll().Select(c => new CustomerViewModel 
                                    { id = c.CustomerID, ciudad = c.City, Compania = c.CompanyName }).ToList();
            return View(result);
        }

        public ActionResult Eliminar(string id)
        {
            try
            {
                ClientesLogic clogic = new ClientesLogic();
                clogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        public ActionResult Editar(string id)
        {
            try
            {
                
                ClientesLogic clientes = new ClientesLogic();
                var entity = clientes.GetById(id);
                CustomerViewModel model = new CustomerViewModel() {id=entity.CustomerID , 
                                                ciudad = entity.City, Compania =entity.CompanyName};

                ViewBag.EsInsert = false;   
                return View("FormCustomers",model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Editar(CustomerViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClientesLogic clientes = new ClientesLogic();
                    clientes.Update(new Customers
                    {
                        CustomerID = model.id,
                        City = model.ciudad,
                        CompanyName = model.Compania
                    });
                    return RedirectToAction("Index");
                }
                return View("FormCustomers",model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }      


        public ActionResult Insertar()
        {
            CustomerViewModel toCreate = new CustomerViewModel();
            ViewBag.EsInsert = true;
            return View("FormCustomers",toCreate);
        }
        
        [HttpPost] 
        public ActionResult Insertar(CustomerViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClientesLogic clogic = new ClientesLogic();
                    Customers cobject = new Customers
                    {
                        CustomerID = model.id.Trim(),
                        City = model.ciudad,
                        CompanyName = model.Compania
                    };
                    clogic.Add(cobject);
                    return RedirectToAction("Index");
                }
                return View("FormCustomers",model);
            }   
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}