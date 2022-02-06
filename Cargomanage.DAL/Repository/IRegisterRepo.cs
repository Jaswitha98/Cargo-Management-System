using Cargomanage.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargomanage.DAL.Repository
{
    public interface IRegisterRepo
    {
        void Register(Cargoregister cargoregister);
        Cargoregister Login(Cargoregister cargologin);

    }
}
