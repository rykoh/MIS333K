using Microsoft.AspNetCore.Mvc;
using System;
using Kohanski_Ryan_HW4.DAL;

namespace Kohanski_Ryan_HW4.Controllers
{
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

        public IActionResult SeedGenres()
        {
            try
            {
                Seeding.SeedGenres.SeedAllGenres(_db);
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error adding genres to the database",
                                                    ex.Message,
                                                    ex.InnerException.Message,
                                                    ex.InnerException.InnerException.Message});
            }

            return View("Confirm");
        }

        public IActionResult SeedMovies()
        {
            try
            {
                Seeding.SeedMovies.SeedAllMovies(_db);
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error adding movies to the database",
                                                    ex.Message,
                                                    ex.InnerException.Message,
                                                    ex.InnerException.InnerException.Message});
            }

            return View("Confirm");
        }
    }
}