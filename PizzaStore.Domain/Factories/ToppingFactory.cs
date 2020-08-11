using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Factories
{
  public class ToppingFactory : IFactory<ToppingModel>
  {
    public ToppingModel Create()
    {
      var p = new ToppingModel();

      return p;
    }
  }
}