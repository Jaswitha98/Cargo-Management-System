using Cargomanage.BAL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cargomanage.Entity.Models;

namespace Cargomanage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransController : ControllerBase
    {
        private Transservice _transservice;
        public TransController(Transservice transservice)
        {
            _transservice = transservice;
        }
        [HttpGet("GetTranscation_details")]
        public IEnumerable<Transaction> GetTranscation_details()
        {
            return _transservice.GetTranscation_details();
        }
        [HttpPost("AddTranscation_details")]
        public IActionResult AddTranscation_details([FromBody] Transaction transaction)
        {
            _transservice.AddTranscation_details(transaction);
            return Ok("Successfully added Transaction Details");
        }
        [HttpDelete("DeleteTranscation_details")]
        public IActionResult DeleteTranscation_details(int Bill_no)
        {
            _transservice.DeleteTranscation_details( Bill_no);
            return Ok("Successfully deleted Transaction Details");
        }
        [HttpPut("UpdateTranscation_details")]
        public IActionResult UpdateTranscation_details(Transaction transaction)
        {
            _transservice.UpdateTranscation_details(transaction);
            return Ok("Transaction details updated successfully!!");
        }
        [HttpGet("GetTranscation_detailsbyno")]
        public void GetTranscation_detailsbyno(int Bill_no)
        {
             _transservice.GetTranscation_detailsbyno(Bill_no);
            
        }
    }
}
