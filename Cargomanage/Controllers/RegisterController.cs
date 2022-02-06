using Cargomanage.BAL.Services;
using Cargomanage.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cargomanage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private Registerservice _registerservice;
        public RegisterController(Registerservice registerservice)
        {
            _registerservice = registerservice;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] Cargoregister cargoregister )
        {
            _registerservice.Register(cargoregister);
            return Ok("Register successfully");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Cargoregister cargologin)
        {
            Cargoregister user = _registerservice.Login(cargologin);
            if (user != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
    }
}
