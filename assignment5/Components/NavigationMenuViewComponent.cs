using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment5.Models;

namespace assignment5.Components
{
    //Component which dynamically builds the Search
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Projects
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
