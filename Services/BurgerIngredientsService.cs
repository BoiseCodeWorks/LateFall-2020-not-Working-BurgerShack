using System;
using burgershack.Repositories;

namespace burgershack.Services
{
  public class BurgerIngredientsService

  {
    private readonly BurgerIngredintsRepository _repo;

    public BurgerIngredientsService(BurgerIngredintsRepository repo)
    {
      _repo = repo;
    }

    internal object Create(int burgerId, int ingredientId)
    {
      throw new NotImplementedException();
    }

    internal object Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}