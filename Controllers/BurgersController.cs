using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack.Models;
using burgershack.Services;
using Microsoft.Extensions.Logging;

namespace burgershack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController
  {
    private readonly BurgersService _burgersService;

    public BurgersController(BurgersService burgersService)
    {
      _burgersService = burgersService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> GetAction()
    {
      try
      {
        return Ok(_burgersService.Get());
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Burger> GetById(int id)
    {
      try
      {
        return Ok(_burgersService.GetById(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger newBurger)
    {
      try
      {
        return Ok(_burgersService.Create(newBurger));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Burger> Update(int id, [FromBody] Burger updatedBurger)
    {
      try
      {
        return Ok(_burgersService.Update(id, updatedBurger));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_burgersService.Delete(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}