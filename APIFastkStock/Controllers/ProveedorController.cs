using APIFastkStock.Models.Interfaz;
using APIFastkStock.Models.ViewModels;
using APIFastkStock.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFastkStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : Controller
    {
        private readonly IDapperConsultasDB _dapper;
        private readonly ProveedorService proveedorService;

        public ProveedorController(IDapperConsultasDB dapper)
        {
            _dapper = dapper;

            proveedorService = new ProveedorService(dapper);
        }


        [HttpGet("[Action]")]
        public ActionResult GetProveedor()
        {
            try
            {
                var response = proveedorService.GetProveedor();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public ActionResult SetProveedor([FromBody] List<GetProveedores> setTransit)
        {
            try
            {
                var response = proveedorService.SetProveedor(setTransit);

                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
