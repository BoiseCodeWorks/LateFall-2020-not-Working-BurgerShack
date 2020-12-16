using System.Collections.Generic;
using System.Data;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class BurgerIngredientsRepository
  {

    private readonly IDbConnection _db;

    public BurgerIngredientsRepository(IDbConnection db)
    {
      _db = db;
    }
    public IEnumerable<BurgerIngredient> Get()
    {
      string sql = @"
      SELECT * FROM burgerIngredients";
      return _db.Query<BurgerIngredient>(sql);
    }
  }
}