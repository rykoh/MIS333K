using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net;
//using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;
using sp20team13finalproject.Models.ViewModels;
using sp20team13finalproject.Utilities;

namespace sp20team13finalproject.Controllers
{
    [Authorize(Roles = "Customer, TicketAgent, Management")]
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public ReservationsController(AppDbContext context,IServiceProvider service)
        {
            _context = context;
            _userManager = service.GetRequiredService<UserManager<AppUser>>();

        }

        public const Decimal SENIOR_DISCOUNT = 0.10m; // Senior Discount: 10% - Age 65+
        public const Decimal CHILD_DISCOUNT = 0.15m; // Child Discount: 15% - Age 0-12
        public const Decimal FIRST_CLASS = 1.20m; // First Class Seat Premium: 20%
        public const Decimal SALES_TAX = 0.0775m; // Sales Tax: 7.75%
        public const Decimal MODIFICATION_FEE = 50.00m; // Reservation Modification Fee: $50 (does NOT include changing seats on same flight)


    

    // GET: Reservations
    public IActionResult Index()
        {
            //get all the registrations from the database and include the registration details
            List<Reservation> reservations = new List<Reservation>();
            if (User.IsInRole("Management"))
            {
                reservations = _context.Reservations.Include(r => r.Tickets).ToList();
            }
            else //user is customer
            {
                reservations = _context.Reservations.Where(r => r.AppUser.UserName == User.Identity.Name).Include(r => r.Tickets).ToList();
            }

            return View(reservations);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            //update this statement to have an include clause to get the registration details
            //and course information
            Reservation reservation = await _context.Reservations
                .Include(r => r.Tickets).ThenInclude(r => r.FlightDetail).ThenInclude(r => r.Flight)
                .Include(r => r.AppUser)
                .FirstOrDefaultAsync(m => m.ReservationID == id);

            if (reservation == null)
            {
                return View("Error", new String[] { "Cannot find this reservation!" });
            }

            if (User.IsInRole("Management") == false && reservation.AppUser.UserName != User.Identity.Name) //they are trying to see something that isn't theirs
            {
                return View("Error", new String[] { "Unauthorized: You are attempting to view another customer's registration!" });
            }

            return View(reservation);
        }
        
        //GET
        public async Task<IActionResult> Checkout(Int32 id)
        {
            Reservation reservation = await _context.Reservations
                .Include(r => r.Tickets).ThenInclude(r => r.FlightDetail).ThenInclude(r => r.Flight)
                .Include(r => r.AppUser)
                .FirstOrDefaultAsync(m => m.ReservationID == id);

            return View(reservation);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(int id, [Bind("ReservationID,ReservationNum,ReservationDate,ReservationNotes, PaymentMethod, FlightDetail")] Reservation reservation)
        {
            Reservation res = await _context.Reservations
                .Include(r => r.Tickets).ThenInclude(r => r.FlightDetail).ThenInclude(r => r.Flight)
                .Include(r => r.AppUser)
                .FirstOrDefaultAsync(m => m.ReservationID == id);

            if (reservation.PaymentMethod == PaymentType.Card)
            {
                return View("Receipt", reservation);
            }
            else if (reservation.PaymentMethod == PaymentType.Miles)
            {
                //ticket.User = await _userManager.FindByNameAsync(User.Identity.Name);
                Int32 FirstClassCount = 0;
                Int32 EconomyCount = 0;

                foreach (Ticket t in res.Tickets)
                {
                    if (t.SeatFare == Utilities.FareType.Economy)
                    {
                        EconomyCount = EconomyCount + 1;
                    }
                    else if (t.SeatFare == Utilities.FareType.First)
                    {
                        FirstClassCount = FirstClassCount + 1;
                    }
                }
                FirstClassCount = FirstClassCount * 2000;
                EconomyCount = EconomyCount * 1000;
                Int32 RequiredMiles = FirstClassCount + EconomyCount;

                if (res.AppUser.Miles > RequiredMiles)
                {

                    res.AppUser.Miles = res.AppUser.Miles - RequiredMiles;
                    _context.Update(res.AppUser);
                    await _context.SaveChangesAsync();
                    return View("Receipt", res);
                }
                else if (res.AppUser.Miles < RequiredMiles)
                {
                    ViewBag.ErrorMessage = "Not enough miles to redeem free flight(s)";
                    return View();
                }
            }

            return View();
        }

            [Authorize(Roles = "Management")]
        public IActionResult CreateManagement()
        {
            ViewBag.AllCustomers = GetAllCustomers();
            ViewBag.AllSeats = GetAllSeats();

            ManagementViewModel mvm = new ManagementViewModel();



            return View(mvm);
        }

        [Authorize(Roles = "Management")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateManagement([Bind("AdvantageNum, ReservationNum, FlightNum, Date, Seat, Reservation")] ManagementViewModel mvm, Int32 SelectedCustomer, Int32 SelectedSeat)
        {
            Reservation reservation = new Reservation();
            reservation.ReservationNum = mvm.ReservationNum;
            mvm.Reservation = reservation;
            Ticket ticket = new Ticket();

            var query = from fd in _context.FlightDetails
                        select fd;

            query = query.Where(fd => fd.Flight.FlightNum == mvm.FlightNum & fd.Date == mvm.Date);

            List<FlightDetail> fds = (query.ToList());
            FlightDetail NoFlightDetail = new FlightDetail { FlightDetailID = 0, FlightNum = 0 };
            fds.Add(NoFlightDetail);
            FlightDetail fd1 = fds[0];

            ticket.FlightDetail = fd1;

            AppUser user = _context.Users
                .FirstOrDefault(u => u.AdvantageNum == SelectedCustomer);

            mvm.Reservation.AppUser = user;
            ticket.User = user;
            mvm.Reservation.ReservationDate = DateTime.Now;

            //reservation.ReservationID = mvm.ReservationID;

            foreach (Seat seat in FindAvailableSeats.GetAllSeats())
            {
                if (SelectedSeat == seat.SeatID)
                {
                    ticket.SeatName = seat.Name;
                    ticket.SeatFare = seat.FareType;
                }
            }

            ticket.Reservation = mvm.Reservation;
            ticket.CustomerFirstName = user.FirstName;
            ticket.CustomerLastName = user.LastName;
            ticket.FlightDetail.FlightNum = mvm.FlightNum;

            string DateOfBirth = user.DOB.Substring(0, 2) + "/" + user.DOB.Substring(2, 2) + "/" + user.DOB.Substring(4, 2);
            DateTime DOB = DateTime.Parse(DateOfBirth);
            Int32 age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
            {
                age = age - 1;
            }

            if (ticket.SeatFare == FareType.Economy)
            {
                if (age <= 12)
                {
                    ticket.Price = (ticket.FlightDetail.BaseFare * (1 - CHILD_DISCOUNT));
                }
                else if (age >= 65)
                {
                    ticket.Price = (ticket.FlightDetail.BaseFare * (1 - SENIOR_DISCOUNT));
                }
                else
                {
                    ticket.Price = ticket.FlightDetail.BaseFare;
                }
            }
            else if (ticket.SeatFare == FareType.First)
            {
                ticket.Price = ticket.FlightDetail.BaseFare * FIRST_CLASS;
            }

            mvm.Reservation.Tickets.Add(ticket);

            if (ModelState.IsValid)
            {
                _context.Add(mvm.Reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Reservations", new { reservationId = mvm.Reservation.ReservationID });
                // No more user input
            }
            return View(mvm.Reservation);

        }
    

        // GET: Reservations/Create
        public IActionResult Create(int flightdetailID)
        {
            FlightDetail fd = _context.FlightDetails
                .Include(f => f.Flight.DepartingAirport).Include(f => f.Flight.ArrivingAirport)
                .FirstOrDefault(f => f.FlightDetailID == flightdetailID);
            /*
            FlightDetail fd2 = _context.FlightDetails
                .Include(f => f.Flight.DepartingAirport).Include(f => f.Flight.ArrivingAirport)
                .FirstOrDefault(f => f.FlightDetailID == flightDetailID2);
            */
            SearchViewModel svm = new SearchViewModel();
            svm.DepartureSearch = fd.Flight.DepartingAirport.AirportID; //DepCity? needs to come from flight class
            svm.ArrivalSearch = fd.Flight.ArrivingAirport.AirportID; // ArrCity?
            //Set restr of values from search
            svm.FlightDetail = fd;
            //svm.FlightDetail2 = fd2;

            return View(svm);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationID,ReservationNum,ReservationDate,ReservationNotes, FlightDetail")] Reservation reservation, int flightdetailID, SearchViewModel svm)
        {
            reservation.ReservationNum = Utilities.GenerateNextReservationNumber.GetNextReservationNumber(_context);
            reservation.ReservationDate = DateTime.Now;

            FlightDetail DBfd = _context.FlightDetails.Find(svm.FlightDetail.FlightDetailID);

            reservation.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Tickets", new { reservationId = reservation.ReservationID, flightdetailID = svm.FlightDetail.FlightDetailID});
                // No more user input
            }
            return View(reservation); // Need User input
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reservation reservation = await _context.Reservations
                .Include(r => r.Tickets).ThenInclude(r => r.FlightDetail).ThenInclude(r => r.Flight)
                .Include(r => r.AppUser)
                .FirstOrDefaultAsync(m => m.ReservationID == id);

            //var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationID,ReservationNum")] Reservation reservation)
        {
            if (id != reservation.ReservationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ReservationID))
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
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }

        public SelectList GetAllCustomers()
        {
            // Get all users
            var query = from u in _context.Users
                        select u;

            // Get only users who are customers
            query = query.Where(u => u.AdvantageNum != 0);

            // Make a list of those users
            List<AppUser> AllUsers = query.ToList();
            AllUsers.OrderBy(u => u.UserName);

            //List<AppUser> AllUsers = _context.Users.ToList();

            //Turn this into a select list
            SelectList slAllUsers = new SelectList(AllUsers.OrderBy(u => u.AdvantageNum), "AdvantageNum", "AdvantageNum");

            //return the select list you just created
            return slAllUsers;
        }

        private SelectList GetAllSeats()
        {
            List<Seat> AllSeats = FindAvailableSeats.GetAllSeats().ToList();

            Seat NoSeat = new Seat() { SeatID = 0, Name = "Select Seat" };
            AllSeats.Add(NoSeat);

            SelectList seats = new SelectList(AllSeats.OrderBy(t => t.SeatID), "SeatID", "Name");

            return seats;
        }
    }
}
