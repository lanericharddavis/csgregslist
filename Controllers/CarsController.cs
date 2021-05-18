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
    private readonly CarsService _service;
    public CarsController(CarsService service)
    {
      _service = service;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(CarsService.GetAll());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}