using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;
namespace PizzaStore.Client.Models
{
  public class PizzaViewModel
  {
    //private PizzaStoreDbContext _db; 
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }


    [Required(ErrorMessage = "Please select a Crust")]
    public string Crust {get; set;}
    [Required]
    public string Size {get; set;}
    [Required]
    [MaxLength(5, ErrorMessage = "You passed your limit of toppings.")]
    [MinLength(2, ErrorMessage = "You need at least 2 toppings to make a good pizza.")]
    public List<string> SelectedToppings {get; set; }
    public List<CheckBoxTopping> SelectedToppings2 {get; set;}
    

    public bool SelectedTopping {get; set;}

    public PizzaViewModel()
    {
      //_db = new PizzaStoreDbContext();
      Crusts = new List<CrustModel>() {new CrustModel() { Name = "Thin"}, new CrustModel() { Name = "Regular"}, new CrustModel() { Name = "Stuffed"}};
      Sizes = new List<SizeModel>() { new SizeModel(){ Name = "Medium"}, new SizeModel(){ Name = "Large"}};
      Toppings = new List<ToppingModel>() 
      {new ToppingModel(){ Name = "Cheese"},  new ToppingModel(){ Name = "Pepperoni"}
      ,new ToppingModel(){ Name = "Sausage"}, new ToppingModel(){ Name = "Bacon"}
      ,new ToppingModel(){ Name = "Ham"},     new ToppingModel(){ Name = "Pineapple"}};
      SelectedToppings2 = new List<CheckBoxTopping>{};
    }

    public CrustModel AddCrust()
    {
      var c = new CrustModel(){Name = Crust};

      return c;
    }

    public SizeModel AddSize()
    {
      var s = new SizeModel(){Name = Size};
      return s;
    }

    public List<ToppingModel> AddToppings()
    {
      var t = new List<ToppingModel>();
      int i = 0;
      foreach(var x in SelectedToppings)
      {
        var top = new ToppingModel(){Name = SelectedToppings[i]};
        t.Add(top);
        i = i + 1;
      }
      return t;
    }


    
/*
    public void AddToppings()
    {
      int i = 0;
      List<ToppingModel> LT;
      foreach(var s in SelectedToppings)
      {
        var t = new ToppingModel(){Name = SelectedToppings[i]};
        LT.Add(t);
        i = i + 1;
      }
      _db.AddToppings(LT);
    }

  */
  }
  public class CheckBoxTopping : ToppingModel
  {
    public string Text{get; set;}
    public bool IsSelected {get; set;}
  }

}
