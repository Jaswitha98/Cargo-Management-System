using Cargomanage.DAL.Data;
using Cargomanage.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cargomanage.DAL.Repository
{
   public class RegisterRepo:IRegisterRepo
    {
        private CargoDBcontext _cargoDBcontext;
        public RegisterRepo(CargoDBcontext cargoDBcontext)
        {
            _cargoDBcontext = cargoDBcontext;
        }
        public Cargoregister Login(Cargoregister cargologin)
        {
            Cargoregister cargoregister = null;
            var result = _cargoDBcontext.Register.Where(obj => obj.Emailid == cargologin.Emailid && obj.Password == cargologin.Password).ToList();
            if(result.Count>0)
            {
                cargoregister = result[0];
            }
            return cargoregister;
        }
        public void Register(Cargoregister cargoregister)
        {
            _cargoDBcontext.Register.Add(cargoregister);
            _cargoDBcontext.SaveChanges();
        }
    }
}
