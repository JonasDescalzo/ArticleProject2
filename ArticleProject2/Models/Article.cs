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

        public string BodyDisplay
        {
            get {
                if (Body.Length < 140)
                    return Body;

                return Body != null ? Body.Substring(0, 137)+ "..." : ""; 
            }
        }

        public string AuthorDisplay
        {
            get
            {
                if (Author.Length < 21)
                    return Author;

                return Author != null ? Author.Substring(0, 17) + "..." : "";
            }
        }
        public string TitleDisplay
        {
            get
            {
                if (Title.Length < 21)
                    return Title;

                return Title != null ? Title.Substring(0, 17) + "..." : "";
            }
        }


    }
}
