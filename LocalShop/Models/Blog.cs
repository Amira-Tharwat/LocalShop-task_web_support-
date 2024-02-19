using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShop.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public int BlogTypeId { get; set; }
        [ForeignKey("BlogTypeId")]
        public BlogType BlogType { get; set; }
    }
}
