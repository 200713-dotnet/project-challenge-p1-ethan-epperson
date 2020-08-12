using System.Collections.Generic;
using domain = PizzaStore.Domain.Models;
using PizzaStore.Domain.Factories;

namespace PizzaStore.Storing.Repository
{
    public class PizzaRepository
    {
        private PizzaStoreDbContext _db;

        public PizzaRepository(PizzaStoreDbContext db)
        {
            _db = db;
        }
/*
        public Pizza CreatePizza(PizzaModel p)
        {
            
            Pizza pi = new Pizza();
            if (p.Crust == "Thin" )
            {
                pi.CrustId = 1;
            }
            else if (p.Size == "Large")
            {
                pi.SizeId = 1;
            }
            //pi.PizzaId = 1;
            
            return pi;
            

        }
        */


    }
}