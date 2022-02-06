using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cargomanage.Entity.Models;


namespace Cargomanage.DAL.Data
{
    public class CargoDBcontext:DbContext
    {
        public CargoDBcontext(DbContextOptions<CargoDBcontext> options):base(options)
        {

        }
        public DbSet<Cargoregister> Register { get; set; } 
        public DbSet<Cust_details> Customer_Details { get; set; }
        public DbSet<Transaction> Transaction_Details { get; set; }
    }
}
