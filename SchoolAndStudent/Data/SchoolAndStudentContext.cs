using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolAndStudent.Models;

namespace SchoolAndStudent.Data
{
    public class SchoolAndStudentContext : DbContext
    {
        public SchoolAndStudentContext (DbContextOptions<SchoolAndStudentContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolAndStudent.Models.Student> Student { get; set; } = default!;
    }
}
