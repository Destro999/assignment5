using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using assignment5.Models;
using assignment5.infastructure;

namespace assignment5.Pages
{
    public class CartModel : PageModel
    {
        private IBookRepository repository;

        public CartModel (IBookRepository repo, Cart cartservices)
        {
            repository = repo;
            Cart = cartservices;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        public IActionResult OnPost(long bookkey, string returnUrl)
        {
            Project project = repository.Projects.FirstOrDefault(p => p.BookKey == bookkey);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(project, 1);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookkey, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Project.BookKey == bookkey).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

    }
}
