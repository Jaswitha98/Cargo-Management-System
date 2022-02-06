using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.Entity.Models;

namespace Cargomanage.DAL.Repository
{
   public interface ITransRepo
    {
        void AddTranscation_details(Transaction transaction);
        void UpdateTranscation_details(Transaction transaction);
        void DeleteTranscation_details(int Bill_no);
        Transaction GetTranscation_detailsbyno(int Bill_no);
        IEnumerable<Transaction> GetTranscation_details();
    }
}
