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

        public void CreatePizza()
        {

        }



    }
}