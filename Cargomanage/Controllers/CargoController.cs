using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cargomanage.BAL.Services;
using Cargomanage.Entity.Models;

namespace Cargomanage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private Cargoservices _cargoservices;
        public CargoController(Cargoservices cargoservices)
        {
            _cargoservices = cargoservices;
        }
        [HttpGet("GetCust_Details")]
        public IEnumerable<Cust_details> GetCust_Details()
        {
            return _cargoservices.GetCustomerdetails();
        }
        [HttpPost("AddCust_detials")]
        public IActionResult AddCust_details([FromBody]Cust_details customer)
        {
            _cargoservices.AddCust_details(customer);
            return Ok("Successfully added Customer Details");
        }
        [HttpDelete("DeleteCust_details")]
        public IActionResult DeleteCust_details(int Sender_id)
        {
            _cargoservices.DeleteCust_details(Sender_id);
            return Ok("Successfully deleted Customer Details");
        }

    }
}
