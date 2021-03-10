using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment5.Models;
using assignment5.Pages;


namespace assignment5.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public Paginginfo Paginginfo { get; set; }
        public string CurrentCategory { get; set;}

    }
}
