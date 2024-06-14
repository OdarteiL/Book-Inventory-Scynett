using System.ComponentModel.DataAnnotations;

namespace bookinventory.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Title { get; set; }

    [Required]
    [StringLength(50)]
    public required string Author { get; set; }

    [Required]
    [StringLength(50)]
    public required string Genre { get; set; }

    [Range(1, 100)]
    public required decimal Price { get; set; }

    public DateTime PublicationDate { get; set; }
}