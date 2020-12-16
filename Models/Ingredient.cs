using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
  public class Ingredient
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public int Cal { get; set; }

  }
}