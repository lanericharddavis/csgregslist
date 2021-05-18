using System;
using System.Collections.Generic;
using csgregslist.Models;
using csgregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace csgregslist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _carsService;
    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(_carsService.GetAll());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Car>> GetById(string id)
    {
      try
      {
        return Ok(_carsService.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _carsService.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Car> Edit([FromBody] Car editCar, string id)
    {
      try
      {
        editCar.Id = id;
        Car car = _carsService.Edit(editCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCar(string id)
    {
      try
      {
        _carsService.DeleteCar(id);
        return Ok("Deleted Car Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}