using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Cargomanage.Entity.Models
{
   public class Cargoregister
    {
        public string Name { get; set; }
        [Key]
        public string Emailid { get; set; }
        public int MobileNo { get; set; }
        public string Password { get; set; }
        public string Retypepswd { get; set; }
    }
}
