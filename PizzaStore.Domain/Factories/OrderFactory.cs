using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Factories
{
  public class OrderFactory : IFactory<OrderModel>
  {
    public OrderModel Create()
    {
      var o = new OrderModel();
      return o;
    }
  }
}