using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.DataContext;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataAccessContext _context;



        public HomeController(ILogger<HomeController> logger , DataAccessContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Id,First_Name,Last_Name,Email,Password")] Users users)
        {
            if (ModelState.IsValid)
            {
                var data = await _context.Users.Where(u => u.Email == users.Email).FirstOrDefaultAsync();
                if(data != null)
                {
                    ModelState.AddModelError("", "User with this mail already exist");
                    return View(users);
                }
                _context.Users.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(login));
            }
            return View(users);
        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login([Bind("Email,Password")] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var daata =await _context.Users.Where(u => u.Email == loginModel.Email).FirstOrDefaultAsync();
                if (daata == null || daata.Password != loginModel.Password)
                {
                    ModelState.AddModelError("", "Incorrect email or password");
                    return View(loginModel);

                }
            }
            return RedirectToAction(nameof(Privacy));
        }


 
        // GET: student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

    }
}
