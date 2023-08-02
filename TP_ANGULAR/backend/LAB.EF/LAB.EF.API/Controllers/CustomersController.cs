using LAB.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using LAB.EF.API.Models;
using System.Web.Http.Cors;

namespace LAB.EF.API.Controllers
{
    [EnableCors("*","*","*")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {

            ClientesLogic clogic = new ClientesLogic();
            List<CustomerViewModel> customers = clogic.GetAll().Select(x => new CustomerViewModel
            {
                id = x.CustomerID, ciudad = x.City, Compania = x.CompanyName
            }).ToList();

            if (customers.Count == 0)
                return BadRequest("No hay clientes");

            return Ok(customers);
        }

        [HttpGet]
        public IHttpActionResult GetById(string id)
        {
            try
            {
                ClientesLogic clogic = new ClientesLogic();
                var entity = clogic.GetById(id);
                if (entity != null)
                {
                    CustomerViewModel model = new CustomerViewModel
                    {
                        ciudad = entity.City,
                        id = entity.CustomerID,
                        Compania = entity.CompanyName
                    };
                    return Ok(model);
                }
                return NotFound();
            }

            catch
            {
                return BadRequest();
            }
        }


        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            try
            {
                if (id == null || id=="")
                    return NotFound();

                ClientesLogic clogic = new ClientesLogic();
                clogic.Delete(id);
                return Ok($"Usuario con ID:{id} eliminado exitosamente");
            }
            catch
            {
                return BadRequest("No se pudo eliminar el cliente");
            }
        }

        [HttpPost]
        public IHttpActionResult Post(CustomerViewModel model)
        {
            try
            {
                if (model == null)
                    return NotFound();

                var clogic = new ClientesLogic();
                clogic.Add(new Entities.Customers
                {
                    CustomerID = model.id,
                    City = model.ciudad,
                    CompanyName = model.Compania
                });
                return Ok(model);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult Put(CustomerViewModel model)
        {
            try
            {
                if (model==null)
                    return NotFound();

                ClientesLogic clientes = new ClientesLogic();
                clientes.Update(new Entities.Customers
                {
                    CustomerID = model.id,
                    City = model.ciudad,
                    CompanyName = model.Compania
                });
                return Ok($"El cliente con ID:{model.id} ha sido modificado correctamente");
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
