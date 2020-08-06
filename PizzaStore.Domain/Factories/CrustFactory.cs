using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Factories
{
  public class CrustFactory : IFactory<CrustModel>
  {
    public CrustModel Create()
    {
      var p = new CrustModel();

      return p;
    }
  }
}