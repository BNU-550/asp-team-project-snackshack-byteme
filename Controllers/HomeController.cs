using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Snack_Shack.Data;
using Snack_Shack.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        { 
            return View();
        }

        // GET: Drinks
        public async Task<IActionResult> Drinks()
        {
            var drinks = _context.Drinks.Include(f => f.Product);
            return View(await drinks.ToListAsync());
        }

        // GET: Food
        public async Task<IActionResult> Food()
        {
            var food = _context.Food.Include(f => f.Product);
            return View(await food.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
