using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecopeWebApp.Models;

namespace RecopeWebApp.Data
{
    public class RecopeContext : DbContext
    {
        public RecopeContext (DbContextOptions<RecopeContext> options)
            : base(options)
        {
        }

        public DbSet<RecopeWebApp.Models.Recipes> Recipes { get; set; } = default!;
    }
}
