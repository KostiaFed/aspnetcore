using System.ComponentModel.DataAnnotations;

namespace firstwebapp.Models
{
  public class OrderViewModel
  {
    [Required]
    public string ProductName { get; set; }

    [Range(1, 100)]
    public int Quantity { get; set; }
  }
}
