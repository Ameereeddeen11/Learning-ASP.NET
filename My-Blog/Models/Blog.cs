using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Blog.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        [ForeignKey("UserId")]
        //public UserId User { get; set; }
    }
}
