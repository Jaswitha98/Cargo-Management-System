using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Cargomanage.DAL.Repository
{
   public interface ICustrepository
    {
        void AddCust_details(Cust_details customer);
        void UpdateCust_details(Cust_details customer);
        void DeleteCust_details(int Sender_id);
        Cust_details GetCust_detailsbyid(int Sender_id);
        IEnumerable<Cust_details> GetCust_Details();

    }
}
