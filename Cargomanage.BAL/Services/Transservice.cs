using Cargomanage.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.Entity.Models;

namespace Cargomanage.BAL.Services
{
    public class Transservice
    {
        ITransRepo _transRepo;
        public Transservice(ITransRepo transRepo)
        {
            _transRepo = transRepo;
        }
        public void AddTranscation_details(Transaction transaction)
        {
            _transRepo.AddTranscation_details(transaction);
        }
        public void UpdateTranscation_details(Transaction transaction)
        {
            _transRepo.UpdateTranscation_details(transaction);
        }
        public void DeleteTranscation_details(int Bill_no)
        {
            _transRepo.DeleteTranscation_details(Bill_no);
        }
        public void GetTranscation_detailsbyno(int Bill_no)
        {
            _transRepo.GetTranscation_detailsbyno(Bill_no);
        }
        public IEnumerable<Transaction> GetTranscation_details()
        {
            return _transRepo.GetTranscation_details();
        }

    }
}
