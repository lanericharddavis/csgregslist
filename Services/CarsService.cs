using System.Collections.Generic;
using csgregslist.DB;
using csgregslist.Models;

namespace csgregslist.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> GetAll()
    {
      return FakeDB.Cars;
    }
  }
}