using System;
using System.Collections.Generic;
using System.Data;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class IngredientsRepository
  {
    private readonly IDbConnection _db;

    public IngredientsRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Ingredient> Get()
    {
      string sql = @"
      SELECT * FROM ingredients";
      return _db.Query<Ingredient>(sql);
    }

    public Ingredient GetById(int id)
    {
      string sql = @"
      SELECT * FROM ingredients
      WHERE id = @ID;
      ";
      return _db.QueryFirstOrDefault<Ingredient>(sql, new { id });
    }

    public object Create(Ingredient newIngredient)
    {
      string sql = @"
     INSERT INTO ingredients
     (title, description)
     VALUES
     (@Title, @Description)
     SELECT LAST_INSERT_ID();";
      newIngredient.Id = _db.ExecuteScalar<int>(sql, newIngredient);
      return newIngredient;
    }

    public bool Update(Ingredient updatedIngredient)
    {
      string sql = @"
      UPDATE ingredients
      SET 
      title = @Title,
      description = @Description
      WHERE id = @Id;
      ";
      int rows = _db.Execute(sql, updatedIngredient);
      return rows > 0;
    }

    public bool Delete(int id)
    {
      string sql = "DELETE FROM ingredients WHERE id = @id LIMIT 1;";
      int affectedRows = _db.Execute(sql, new { id });
      // returns a bool
      return affectedRows == 1;
    }
  }
}