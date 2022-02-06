using Cargomanage.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cargomanage.DAL.Repository
{
    public class TransRepo:ITransRepo
    {
        CargoDBcontext _cargoDbcontext;
        public TransRepo(CargoDBcontext cargoDbcontext)
        {
            _cargoDbcontext = cargoDbcontext;
        }
        public void AddTranscation_details(Transaction transaction)
        {
            _cargoDbcontext.Transaction_Details.Add(transaction);
            _cargoDbcontext.SaveChanges();
        }
        public void UpdateTranscation_details(Transaction transaction)
        {
            _cargoDbcontext.Entry(transaction).State = EntityState.Modified;
            _cargoDbcontext.SaveChanges();
        }
        public void DeleteTranscation_details(int Bill_no)
        {
            var transaction = _cargoDbcontext.Transaction_Details.Find(Bill_no);
            _cargoDbcontext.Transaction_Details.Remove(transaction);
            _cargoDbcontext.SaveChanges();
        }
        public Transaction GetTranscation_detailsbyno(int Bill_no)
        {
            return _cargoDbcontext.Transaction_Details.Find(Bill_no);
        }
        public IEnumerable<Transaction> GetTranscation_details()
        {
            return _cargoDbcontext.Transaction_Details.ToList();
        }
    }
}
