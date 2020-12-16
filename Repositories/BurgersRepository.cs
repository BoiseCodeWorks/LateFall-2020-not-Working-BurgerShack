using System;
using System.Collections.Generic;
using System.Data;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class BurgersRepository
  {
    private readonly IDbConnection _db;

    public BurgersRepository(IDbConnection db)
    {
      _db = db;
    }

    public Burger Get()
    {
      string sql = @"
      SELECT * FROM burgers";
      return _db.QueryFirstOrDefault<Burger>(sql);
    }

    public Burger GetById(int id)
    {
      string sql = @"
      SELECT * FROM burgers
      WHERE id = @ID;
      ";
      return _db.QueryFirstOrDefault<Burger>(sql);
    }

    public object Create(Burger newBurger)
    {
      string sql = @"
     INSERT INTO burgers
     (title, description)
     VALUES
     (@Title, @Description)
     SELECT LAST_INSERT_ID();";
      newBurger.Id = _db.ExecuteScalar<int>(sql, newBurger);
      return newBurger;
    }

    public bool Update(Burger updatedBurger)
    {
      string sql = @"
      UPDATE burgers
      SET 
      title = @Title,
      description = @Description
      WHERE id = @Id;
      ";
      int rows = _db.Execute(sql, updatedBurger);
      return rows > 0;
    }

    public bool Delete(int id)
    {
      string sql = "DELETE FROM burgers WHERE id = @id LIMIT 1;";
      int affectedRows = _db.Execute(sql, new { id });
      // returns a bool
      return affectedRows == 1;
    }
  }
}