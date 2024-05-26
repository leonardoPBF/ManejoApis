using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPC3.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPC3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
  
}