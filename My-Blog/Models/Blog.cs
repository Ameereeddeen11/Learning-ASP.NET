using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Blog.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Blog Title")]
        public required string Title { get; set; }
        [Display(Name = "Blog")]
        public required string Content { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
        [ForeignKey("Author")]
        public required string CreatedByUser { get; set; }
        public virtual required IdentityUser Author { get; set; }
    }
}
