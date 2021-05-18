using System.Collections.Generic;
using csgregslist.Models;

namespace csgregslist.DB
{
  public static class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car("Ford", "Bronco", 1966, 5000, "Get ready for a wild ride!"),
            new Car("Fiat", "Bronco", 1957, 8000, "Don't tread on me..."),
            new Car("Pontiac", "Bonneville", 1958, 10000, "Ready for cruising down route66.")
        };
  }
}