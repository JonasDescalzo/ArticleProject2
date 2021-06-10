using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleProject2.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar (250)")]
        [Required(ErrorMessage ="This field is required")]
        public string Title { get; set; }
        
        [Column(TypeName = "varchar (250)")]
        [Required(ErrorMessage = "This field is required")]
        public string Author { get; set; }

        [Column(TypeName = "longtext")]
        [Required(ErrorMessage = "This field is required")]
        public string Body { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

    }
}
