using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cargomanage.Entity.Models
{
   public class Cust_details
    {
        public string Sender_name { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sender_id { get; set; }
        public int Sender_mobno { get; set; }
        public string Sender_address { get; set; }
        public string Sender_city { get; set; }
        public int Sender_pincode { get; set; }

        public string Reciever_name { get; set; }
        public int Reciever_id { get; set; }
        public int Reciever_mobno { get; set; }
        public string Reciever_address { get; set; }
        public string Reciever_city { get; set; }
        public int Reciever_pincode { get; set; }

    }
}
