using System.ComponentModel.DataAnnotations;
namespace SchoolApp.Models
{
    public class School
    {
        public int Id { get; set; }
        public string? SchoolName { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseData { get; set; }
    }
}
