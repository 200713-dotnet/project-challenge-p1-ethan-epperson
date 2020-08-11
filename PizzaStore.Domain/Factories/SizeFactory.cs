using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Factories
{
  public class SizeFactory : IFactory<SizeModel>
  {
    public SizeModel Create()
    {
      var p = new SizeModel();

      return p;
    }
  }
}