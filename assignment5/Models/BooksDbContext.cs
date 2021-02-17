using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment5.Models
{
    //database (following Professor Hiltons example
    public class BooksDbContext : DbContext
    {
        public BooksDbContext (DbContextOptions<BooksDbContext> options) : base (options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
