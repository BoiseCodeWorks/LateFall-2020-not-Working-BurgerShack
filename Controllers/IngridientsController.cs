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
  public class IngredientsController : ControllerBase
  {
    private readonly IngredientsService _ingredientsService;

    public IngredientsController(IngredientsService ingredientsService)
    {
      _ingredientsService = ingredientsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Ingredient>> GetAction()
    {
      try
      {
        return Ok(_ingredientsService.Get());
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Ingredient> GetById(int id)
    {
      try
      {
        return Ok(_ingredientsService.GetById(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<Ingredient> Create([FromBody] Ingredient newIngredient)
    {
      try
      {
        return Ok(_ingredientsService.Create(newIngredient));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Ingredient> Update(int id, [FromBody] Ingredient updatedIngredient)
    {
      try
      {
        return Ok(_ingredientsService.Update(id, updatedIngredient));
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
        return Ok(_ingredientsService.Delete(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}