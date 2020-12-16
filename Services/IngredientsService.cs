using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Services
{
  public class IngredientsService
  {
    private readonly IngredientsRepository _repo;

    public IngredientsService(IngredientsRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Ingredient> Get()
    {
      return _repo.Get();
    }

    public Ingredient GetById(int id)
    {
      return _repo.GetById(id);
    }

    internal object Create(Ingredient newIngredient)
    {
      return _repo.Create(newIngredient);
    }

    internal object Update(int id, Ingredient updatedIngredient)
    {
      Ingredient original = GetById(id);
      updatedIngredient.Id = id;
      updatedIngredient.Title = updatedIngredient.Title == null ? original.Title : updatedIngredient.Title;
      updatedIngredient.Cal = updatedIngredient.Cal == null ? original.Cal : updatedIngredient.Cal;
      if (_repo.Update(updatedIngredient))
      {
        return updatedIngredient;
      }
      throw new Exception("oop that Ingredient dont fly homie");
    }

    internal object Delete(int id)
    {
      Ingredient foundIngredient = GetById(id);
      if (_repo.Delete(id))
      {
        return "Very good, Great Success, the Ingredient is she gone!";
      }
      throw new Exception
      ("that did nut work, that Ingredient is not alive");
    }
  }
}