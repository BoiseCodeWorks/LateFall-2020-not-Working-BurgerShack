using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _repo;

    public BurgersService(BurgersRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Burger> Get()
    {
      return _repo.Get();
    }

    public Burger GetById(int id)
    {
      return _repo.GetById(id);
    }

    internal object Create(Burger newBurger)
    {
      return _repo.Create(newBurger);
    }

    internal object Update(int id, Burger updatedBurger)
    {
      Burger original = GetById(id);
      updatedBurger.Id = id;
      updatedBurger.Title = updatedBurger.Title == null ? original.Title : updatedBurger.Title;
      updatedBurger.Description = updatedBurger.Description == null ? original.Description : updatedBurger.Description;
      if (_repo.Update(updatedBurger))
      {
        return updatedBurger;
      }
      throw new Exception("oop that burger dont fly homie");
    }

    internal object Delete(int id)
    {
      Burger foundBurger = GetById(id);
      if (_repo.Delete(id))
      {
        return "Very good, Great Success, the Burger is she gone!";
      }
      throw new Exception
      ("that did nut work, that burger is not alive");
    }
  }
}