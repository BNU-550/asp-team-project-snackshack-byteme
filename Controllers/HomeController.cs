using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        public IActionResult ContactUs()
        {
            return View();
        }


        // GET: Drinks
        public async Task<IActionResult> Drinks()
        {
            var drinks = _context.Drinks.Include(f => f.Product);
            return View(await drinks.ToListAsync());
        }

        public async Task<IActionResult> Wines()
        {

            var drinks = _context.Drinks.Include(f => f.Product).Where(d => d.DrinkCategory == DrinkCategory.Wines);
            return View(await drinks.ToListAsync());
        }
        public async Task<IActionResult> Beers()
        {

            var drinks = _context.Drinks.Include(f => f.Product).Where(d => d.DrinkCategory == DrinkCategory.Beers);
            return View(await drinks.ToListAsync());
        }

        public async Task<IActionResult> Spirits()
        {

            var drinks = _context.Drinks.Include(f => f.Product).Where(d => d.DrinkCategory == DrinkCategory.Spirits);
            return View(await drinks.ToListAsync());
        }

        public async Task<IActionResult> SoftDrinks()
        {

            var drinks = _context.Drinks.Include(f => f.Product).Where(d => d.DrinkCategory == DrinkCategory.SoftDrinks);
            return View(await drinks.ToListAsync());
        }

        public async Task<IActionResult> HotDrinks()
        {

            var drinks = _context.Drinks.Include(f => f.Product).Where(d => d.DrinkCategory == DrinkCategory.HotDrinks);
            return View(await drinks.ToListAsync());
        }

        public async Task<IActionResult> WhiteWines()
        {

            var drinks = _context.Drinks.Include(f => f.Product).Where(d => d.SubCategory == DrinkSubCategory.White);
            return View(await drinks.ToListAsync());
        }




        // GET: Food
        public async Task<IActionResult> Food()
        {
            var food = _context.Food.Include(f => f.Product);
            return View(await food.ToListAsync());
        }

        // GET: FoodCatergories
        //public async Task<IActionResult> FoodCategory()
        //{
        //    var applicationDbContext = _context.Food.Include(f => f.FoodCategory);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public async Task<IActionResult> Starters()
        {

            var food = _context.Food.Include(f => f.Product).Where(f => f.FoodCategory == FoodCategory.Starters);
            return View(await food.ToListAsync());
        }

        public async Task<IActionResult> Mains()
        {

            var food = _context.Food.Include(f => f.Product).Where(f => f.FoodCategory == FoodCategory.Mains);
            return View(await food.ToListAsync());
        }

        public async Task<IActionResult> Desserts()
        {

            var food = _context.Food.Include(f => f.Product).Where(f => f.FoodCategory == FoodCategory.Desserts);
            return View(await food.ToListAsync());
        }

        public async Task<IActionResult> Sides()
        {

            var food = _context.Food.Include(f => f.Product).Where(f => f.FoodCategory == FoodCategory.Sides);
            return View(await food.ToListAsync());
        }

        // GET: Foods/Details/5
        public async Task<IActionResult> FoodDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Food
                .Include(f => f.Product)
                .FirstOrDefaultAsync(m => m.FoodID == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // GET: Foods/Details/5
        public async Task<IActionResult> DrinksDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Drinks
                .Include(f => f.Product)
                .FirstOrDefaultAsync(m => m.DrinkID == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // ToDo: May need other create
        // POST: Feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FeedbackID,OrderID,FeedbackMessage,CustomerReviewDate")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", feedback.OrderID);
            return View(feedback);
        }




        // GET: People/Details/5
        public async Task<IActionResult> MyAccount()
        {
            ReturnPage.Name = ReturnPage.MyAccount;
            string name = User.Identity.Name;

            var person = await _context.People
                .FirstOrDefaultAsync(m => m.EmailAddress == name);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}