﻿using LocalShop.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShop.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="You must enter the title of blog")]
        [Length(2,200 , ErrorMessage = "The title must be greater than 2 chars  and less than 200 chars")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter the Description of blog")]
        [Length(10,300,ErrorMessage = "Description must be greater than 10 chars  and less than 300 chars")]
        [DescriptionForType(100)]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "You must enter the AuthorName of blog")]
        [Length(2,200 , ErrorMessage = "Description must be greater than 2 chars and less than 200 chars ")]
        public string AuthorName { get; set; }
     
        [Required]
        public int BlogTypeId { get; set; }
        [ForeignKey("BlogTypeId")]
        public BlogType? BlogType { get; set; }
    }
}
