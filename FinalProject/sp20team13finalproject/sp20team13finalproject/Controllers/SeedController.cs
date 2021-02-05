using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sp20team13finalproject.DAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sp20team13finalproject.Controllers
{
    [Authorize(Roles = "Management")]
    public class SeedController : Controller
    {
        private AppDbContext _db;

        public SeedController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedAirports()
        {
            try
            {
                Seeding.SeedAirports.SeedAllAirports(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The airports have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding airports to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedFlightDetails()
        {
            try
            {
                Seeding.SeedFlightDetails.SeedAllFlightDetails(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The flight details have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding flight details to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedFlights()
        {
            try
            {
                Seeding.SeedFlights.SeedAllFlights(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The flights have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding flights to the database", ex.Message });
            }

            return View("Confirm");
        }
    }
}