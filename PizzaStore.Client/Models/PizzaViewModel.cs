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


    [Required(ErrorMessage = "Please select a Crust")]
    public string Crust {get; set;}
    [Required]
    public string Size {get; set;}
    [Required]
    [MaxLength(5)]
    [MinLength(2)]
    public List<string> SelectedToppings {get; set; }
    //public List<CheckBoxTopping> SelectedToppings2 {get; set;}

    public bool SelectedTopping {get; set;}

    public PizzaViewModel()
    {
      Crusts = new List<CrustModel>() {new CrustModel() { Name = "Thin"}, new CrustModel() { Name = "Regular"}, new CrustModel() { Name = "Stuffed"}};
      //Crusts = new CrustFactory() { Name = "Thin"};
      Sizes = new List<SizeModel>() { new SizeModel(){ Name = "Medium"}, new SizeModel(){ Name = "Large"}};
      Toppings = new List<ToppingModel>() 
      {new ToppingModel(){ Name = "Cheese"},  new ToppingModel(){ Name = "Pepperoni"}
      ,new ToppingModel(){ Name = "Sausage"}, new ToppingModel(){ Name = "Bacon"}
      ,new ToppingModel(){ Name = "Ham"},     new ToppingModel(){ Name = "Pineapple"}};
      //SelectedToppings = new List<CheckBoxTopping>();
    }

  }

  public class CheckBoxTopping : ToppingModel
  {
    public string Text{get; set;}
    public bool IsSelected {get; set;}
  }

}
