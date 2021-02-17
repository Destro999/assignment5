using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment5.Models
{
    //database (following Professor Hiltons example
    public class EFCBookRepository : IBookRepository
    {
        private BooksDbContext _context;

        //Constructor
        public EFCBookRepository (BooksDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
