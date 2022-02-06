using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Cargomanage.DAL.Data;
using System.Linq;


namespace Cargomanage.DAL.Repository
{
    public class Custrepository :ICustrepository
    {
        CargoDBcontext _cargoDbcontext;
        public Custrepository(CargoDBcontext cargoDbcontext)
        {
            _cargoDbcontext = cargoDbcontext;
        }
        public void AddCust_details(Cust_details customer)
        {
            _cargoDbcontext.Customer_Details.Add(customer);
            _cargoDbcontext.SaveChanges();
        }
        public void UpdateCust_details(Cust_details customer)
        {
            _cargoDbcontext.Entry(customer).State = EntityState.Modified;
            _cargoDbcontext.SaveChanges();
        }
        public void DeleteCust_details(int Sender_id)
        {
            var customer = _cargoDbcontext.Customer_Details.Find(Sender_id);
            _cargoDbcontext.Customer_Details.Remove(customer);
            _cargoDbcontext.SaveChanges();
        }
        public Cust_details GetCust_detailsbyid(int Sender_id)
        {
            return _cargoDbcontext.Customer_Details.Find(Sender_id);
        }
        public IEnumerable<Cust_details> GetCust_Details()
        {
            return _cargoDbcontext.Customer_Details.ToList();
        }

        
    }
}
