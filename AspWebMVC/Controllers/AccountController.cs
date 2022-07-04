using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using AspWebMVC.Models;

namespace AspWebMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _dataContext;

        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        public async Task<IActionResult> Register(User model)
        {
            await _dataContext.AddAsync(model);
            await _dataContext.SaveChangesAsync();
            return Redirect("Index");
        }
    }
}
