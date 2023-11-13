using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_November.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_November.DAL
{
    internal class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-CCR3N2B;database=AB104EF;trusted_connection=true;integrated security=true;encrypt=false;");
        }
        public DbSet<Student> Students { get; set; }
    }
}
