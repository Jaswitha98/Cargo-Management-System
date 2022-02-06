using Cargomanage.DAL.Repository;
using Cargomanage.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargomanage.BAL.Services
{
   public class Registerservice
    {
        private IRegisterRepo _registerRepo;
        public Registerservice(IRegisterRepo registerRepo)
        {
            _registerRepo = registerRepo;
        }
        public void Register(Cargoregister cargoregister)
        {
            _registerRepo.Register(cargoregister);
        }
        public Cargoregister Login(Cargoregister cargologin)
        {
            return _registerRepo.Login(cargologin);
        }
    }
}
