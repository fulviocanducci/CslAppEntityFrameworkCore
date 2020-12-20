using CslAppEntityFrameworkCore.Models;
using CslAppEntityFrameworkCore.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CslAppEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Db db = new Db())
            {
                var trans = db.Database.BeginTransaction();
                try
                {                    
                    People p = new People();
                    p.Name = "Rosana de Almeida";
                    //p.Address = new Address
                    //{
                    //    Number = "200",
                    //    Street = "Rua Junqueira Lopes"
                    //};
                    db.People.Add(p);
                    db.SaveChanges();
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }                

                //People p = db.People.Find(1);
                //p.Address = new Address
                //{
                //    Number = "190",
                //    Street = "Rua José de Alencar"
                //};

                //People p = db.People.AsNoTrackingWithIdentityResolution()
                //        .Include(c => c.Address)
                //        .FirstOrDefault(x => x.Id == 1);
                
            }
        }
    }
}
