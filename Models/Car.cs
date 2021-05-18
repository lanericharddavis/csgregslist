using System;
using System.ComponentModel.DataAnnotations;

namespace csgregslist.Models
{
  public class Car
  {
    public string Id { get; set; }

    [Required]
    public string Make { get; set; }

    [Required]
    public string Model { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public int Price { get; set; }
    public string Description { get; set; }
    // public string Image { get; set; }

    public Car(string make, string model, int year, int price, string description)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      Description = description;
      //   Image = image;
    }
  }
}