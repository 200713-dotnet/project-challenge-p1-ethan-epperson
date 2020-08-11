using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;
namespace PizzaStore.Client.Models
{
    public class PizzaSpecialViewModel
    {
      
        public List<string> menu { get; set; }


        [Required(ErrorMessage = "Please select a pizza")]
        public string pizzaChoice { get; set; }
        
        public PizzaSpecialViewModel()
        {
            menu = new List<string> { "Pepperoni and Sausage", "Bacon and Ham" };
        }
    }
}