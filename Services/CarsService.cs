using System;
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

    internal Car GetById(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }

    internal Car Edit(Car editCar)
    {
      Car oldCar = GetById(editCar.Id);
      oldCar.Make = editCar.Make;
      oldCar.Model = editCar.Model;
      oldCar.Year = editCar.Year;
      oldCar.Price = editCar.Price;
      oldCar.Description = editCar.Description;

      return oldCar;
    }

    internal void DeleteCar(string id)
    {
      Car found = GetById(id);
      FakeDB.Cars.Remove(found);
    }

  }
}