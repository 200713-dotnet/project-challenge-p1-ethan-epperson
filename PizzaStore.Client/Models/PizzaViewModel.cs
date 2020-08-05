using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class PizzaViewModel
  {
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }
    [Required]
    public CrustModel Crust {get; set;}
    [Required]
    public SizeModel Size {get; set;}
    [Range(2,5)]

    public List<ToppingModel> SelectedToppings {get; set; }

    public bool SelectedTopping {get; set;}

    public PizzaViewModel()
    {
      Crusts = new List<CrustModel>() {new CrustModel() { Name = "Thin"}};
      Sizes = new List<SizeModel>() { new SizeModel(){ Name = "Medium"}};
      Toppings = new List<ToppingModel>() {new ToppingModel(){ Name = "Cheese"}};
    }
  }

}
