using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
  public class Burger
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public Burger(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}