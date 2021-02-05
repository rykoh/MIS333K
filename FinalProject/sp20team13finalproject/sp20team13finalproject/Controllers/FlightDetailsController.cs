using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;

namespace sp20team13finalproject.Controllers
{
    [Authorize(Roles = "Management")]
    public class FlightDetailsController : Controller
    {
        public enum EmpType { None, Pilot, CoPilot, FlightAttendant }

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public FlightDetailsController(AppDbContext context, IServiceProvider service)
        {
            _context = context;
            _userManager = service.GetRequiredService<UserManager<AppUser>>();

        }

        // GET: FlightDetails
        public IActionResult Index()
        {
            List<FlightDetail> flightDetails = new List<FlightDetail>();
            flightDetails = _context.FlightDetails.Include(fd => fd.Flight.DepartingAirport).Include(fd => fd.Flight.ArrivingAirport).ToList();
            /*
            FlightDetail flightDetail = await _context.FlightDetails
                .Include(fd => fd.Flight.DepCity).Include(fd => fd.Flight.ArrivalCity)
                .FirstOrDefaultAsync(m => m.FlightDetailID == id);
            */
            return View(flightDetails);
        }

        // GET: FlightDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlightDetail flightDetail = await _context.FlightDetails
                .Include(fd => fd.Flight.DepartingAirport).Include(fd => fd.Flight.ArrivingAirport)
                .FirstOrDefaultAsync(m => m.FlightDetailID == id);

            /*
            var flightDetail = await _context.FlightDetails
                .FirstOrDefaultAsync(m => m.FlightDetailID == id);
            */

            if (flightDetail == null)
            {
                return NotFound();
            }

            return View(flightDetail);
        }

        // GET: FlightDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlightDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlightDetailID,FlightNum,Date,Pilot,CoPilot,FlightAttendant,BaseFare,flightStatus")] FlightDetail flightDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightDetail);
        }

        // GET: FlightDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlightDetail flightDetail = await _context.FlightDetails
                .Include(fd => fd.Flight.DepartingAirport).Include(fd => fd.Flight.ArrivingAirport)
                .FirstOrDefaultAsync(m => m.FlightDetailID == id);

            /*
            var flightDetail = await _context.FlightDetails
                .FirstOrDefaultAsync(m => m.FlightDetailID == id);
            */

            if (flightDetail == null)
            {
                return NotFound();
            }

            ViewBag.AllPilots = GetAllPilots();
            ViewBag.AllCoPilots = GetAllCoPilots();
            ViewBag.AllFlightAttendants = GetAllFlightAttendants();

            return View(flightDetail);
        }

        // POST: FlightDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("FlightDetailID,FlightNum,Date,Pilot,CoPilot,FlightAttendant,BaseFare,flightStatus")] FlightDetail flightDetail, String SelectedPilot, String SelectedCoPilot, String SelectedFlightAttendant)
        {

            AppUser pilot = _context.Users.FirstOrDefault(u => u.Id == SelectedPilot);
            AppUser copilot = _context.Users.FirstOrDefault(u => u.Id == SelectedCoPilot);
            AppUser flightattendant = _context.Users.FirstOrDefault(u => u.Id == SelectedFlightAttendant);

            flightDetail.Pilot = pilot.FirstName + " " + pilot.LastName;
            flightDetail.CoPilot = copilot.FirstName + " " + copilot.LastName;
            flightDetail.FlightAttendant = flightattendant.FirstName + " " + flightattendant.LastName;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightDetailExists(flightDetail.FlightDetailID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.AllPilots = GetAllPilots();
            ViewBag.AllCoPilots = GetAllCoPilots();
            ViewBag.AllFlightAttendants = GetAllFlightAttendants();

            return View(flightDetail);
        }

        // GET: FlightDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightDetail = await _context.FlightDetails
                .FirstOrDefaultAsync(m => m.FlightDetailID == id);
            if (flightDetail == null)
            {
                return NotFound();
            }

            return View(flightDetail);
        }

        // POST: FlightDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightDetail = await _context.FlightDetails.FindAsync(id);
            _context.FlightDetails.Remove(flightDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightDetailExists(int id)
        {
            return _context.FlightDetails.Any(e => e.FlightDetailID == id);
        }


        public SelectList GetAllPilots()
        {
            // Get all users
            var query = from u in _context.Users
                        select u;

            // Get only users who are customers
            query = query.Where(u => u.empType == AppUser.EmpType.Pilot);

            // Make a list of those users
            List<AppUser> AllPilots = query.ToList();
            AllPilots.OrderBy(u => u.UserName);

            //List<AppUser> AllUsers = _context.Users.ToList();

            //Turn this into a select list
            SelectList slAllPilots = new SelectList(AllPilots.OrderBy(u => u.LastName), "Id", "LastName");

            //return the select list you just created
            return slAllPilots;
        }

        public SelectList GetAllCoPilots()
        {
            // Get all users
            var query = from u in _context.Users
                        select u;

            // Get only users who are customers
            query = query.Where(u => u.empType == AppUser.EmpType.CoPilot);

            // Make a list of those users
            List<AppUser> AllCoPilots = query.ToList();
            AllCoPilots.OrderBy(u => u.UserName);

            //List<AppUser> AllUsers = _context.Users.ToList();

            //Turn this into a select list
            SelectList slAllCoPilots = new SelectList(AllCoPilots.OrderBy(u => u.LastName), "Id", "LastName");

            //return the select list you just created
            return slAllCoPilots;
        }

        public SelectList GetAllFlightAttendants()
        {
            // Get all users
            var query = from u in _context.Users
                        select u;

            // Get only users who are customers
            query = query.Where(u => u.empType == AppUser.EmpType.FlightAttendant);

            // Make a list of those users
            List<AppUser> AllFlightAttendants = query.ToList();
            AllFlightAttendants.OrderBy(u => u.UserName);

            //List<AppUser> AllUsers = _context.Users.ToList();

            //Turn this into a select list
            SelectList slAllFlightAttendants = new SelectList(AllFlightAttendants.OrderBy(u => u.LastName), "Id", "LastName");

            //return the select list you just created
            return slAllFlightAttendants;
        }
    }
}
