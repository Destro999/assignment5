using assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using assignment5.Models.ViewModels;

namespace assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;

        //Return Pages 5 per page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //To pass the databases info to the Index view I've added above the repository info as shown in the videos
        public IActionResult Index(string category, int page = 1)
        {

            //Return Pages 5 per page
            return View(new ProjectListViewModel
            {
                //filter by category
                Projects = _repository.Projects
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.BookKey)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                ,
                Paginginfo = new Paginginfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category== null ? _repository.Projects.Count() :
                    //Page number fixed for categories
                        _repository.Projects.Where (x => x.Category == category).Count()
                },
                CurrentCategory = category
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
