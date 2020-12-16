using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack.Models;
using burgershack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace burgershack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgerIngredientsController : ControllerBase
  {
    private readonly BurgerIngredientsService _service;

    public BurgerIngredientsController(BurgerIngredientsService service)
    {
      _service = service;
    }

    [HttpPost]
    public ActionResult<BurgerIngredient> Create(int burgerId, int ingredientId)
    {
      try
      {
        return Ok(_service.Create(burgerId, ingredientId));
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
        return Ok(_service.Delete(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}