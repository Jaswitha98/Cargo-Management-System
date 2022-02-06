using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.DAL.Repository;
using Cargomanage.Entity.Models;

namespace Cargomanage.BAL.Services
{
    public class Cargoservices
    {
         ICustrepository _custrepository;
        public Cargoservices(ICustrepository custrepository)
        {
            _custrepository = custrepository;
        }
        public void AddCust_details(Cust_details customer)
        {
            _custrepository.AddCust_details(customer);
        }
        public void UpdateCust_details(Cust_details customer)
        {
            _custrepository.UpdateCust_details(customer);
        }
        public void DeleteCust_details(int Sender_id)
        {
            _custrepository.DeleteCust_details(Sender_id);
        }
        public void  GetCust_detailsbyid(int Sender_id)
        {
            _custrepository.GetCust_detailsbyid(Sender_id);
        }
        public IEnumerable<Cust_details> GetCustomerdetails()
        {
           return _custrepository.GetCust_Details();
        }


    }
}
