using System.ComponentModel.DataAnnotations;
namespace SchoolAndStudent.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Grade { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleseDate { get; set; }
    }
}
