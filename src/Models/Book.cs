using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MaxLength(100)]
        [Required]
        public string Author { get; set; }
        
        public int Year { get; set; }
    }
}