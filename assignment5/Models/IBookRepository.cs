using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment5.Models
{
    //hooking up the repository and projects
    public interface IBookRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
