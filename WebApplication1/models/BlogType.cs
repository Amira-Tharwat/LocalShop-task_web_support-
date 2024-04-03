using System.ComponentModel.DataAnnotations;

namespace LocalShop.Models
{
    public class BlogType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
