using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using sp20team13finalproject.Utilities;
using sp20team13finalproject.Models.ViewModels;

namespace sp20team13finalproject.Controllers
{
    [Authorize(Roles = "Customer, TicketAgent, Management")]
    public class TicketsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public const Decimal SENIOR_DISCOUNT = 0.10m; // Senior Discount: 10% - Age 65+
        public const Decimal CHILD_DISCOUNT = 0.15m; // Child Discount: 15% - Age 0-12
        public const Decimal FIRST_CLASS = 1.20m; // First Class Seat Premium: 20%
        public const Decimal SALES_TAX = 0.0775m; // Sales Tax: 7.75%
        public const Decimal MODIFICATION_FEE = 50.00m; // Reservation Modification Fee: $50 (does NOT include changing seats on same flight)

        public TicketsController(AppDbContext context, IServiceProvider service)
        {
            _context = context;
            _userManager = service.GetRequiredService<UserManager<AppUser>>();
        }

        // GET: Tickets
        public IActionResult Index(Int32 reservationId)
        {
            List<Ticket> ts = _context.Tickets
                .Include(t => t.FlightDetail)
                .Where(r => r.Reservation.ReservationID == reservationId).ToList();
            return View(ts);
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(m => m.FlightDetail)
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create

        public IActionResult Create(Int32 reservationId, Int32 flightdetailID)
        {
            FlightDetail fd = _context.FlightDetails
                .Include(f => f.Flight.DepartingAirport).Include(f => f.Flight.ArrivingAirport)
                .FirstOrDefault(f => f.FlightDetailID == flightdetailID);
            /*
            FlightDetail fd2 = _context.FlightDetails
                .Include(f => f.Flight.DepartingAirport).Include(f => f.Flight.ArrivingAirport)
                .FirstOrDefault(f => f.FlightDetailID == flightDetailID2);
            */
            Reservation r = _context.Reservations
                .FirstOrDefault(rs => rs.ReservationID == reservationId);

            Ticket t = new Ticket();
            //Ticket t2 = new Ticket();
            t.Reservation = r;
            t.FlightDetail = fd;
            //t2.Reservation = r;
            //t2.FlightDetail = fd2;

            ViewBag.AllSeats = GetAllSeats();

            return View(t);
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create([Bind("TicketID,CustomerFirstName,CustomerLastName,CustomerEmail,CustomerAdvantageNum,SeatName,Price,Reservation, FlightDetail")] Ticket ticket, int SelectedSeat, SearchViewModel svm)
        {
            // Find the Flight Detail
            //FlightDetail flightDetail = _context.FlightDetails.Find(ticket.FlightDetail.FlightDetailID);
            FlightDetail flightDetail = _context.FlightDetails.Find(svm.FlightDetail.FlightDetailID);

            ticket.FlightDetail = flightDetail;

            // Find the reservation
            Reservation res = _context.Reservations.Find(ticket.Reservation.ReservationID);
            ticket.Reservation = res;

            ticket.User = await _userManager.FindByNameAsync(User.Identity.Name);

            ticket.CustomerFirstName = ticket.User.FirstName;
            ticket.CustomerLastName = ticket.User.LastName;
            ticket.CustomerEmail = ticket.User.Email;
            ticket.CustomerDOB = ticket.User.DOB;
            ticket.CustomerAdvantageNum = ticket.User.AdvantageNum;

            string DateOfBirth = ticket.CustomerDOB.Substring(0, 2) + "/" + ticket.CustomerDOB.Substring(2, 2) + "/" + ticket.CustomerDOB.Substring(4, 2);
            DateTime DOB = DateTime.Parse(DateOfBirth);

            foreach (Seat seat in FindAvailableSeats.GetAllSeats())
            {
                if (SelectedSeat == seat.SeatID)
                {
                    ticket.SeatName = seat.Name;
                    ticket.SeatFare = seat.FareType;
                }
            }
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


            //ROUND TRIP
            // Find the Flight Detail
            //FlightDetail flightDetail = _context.FlightDetails.Find(ticket.FlightDetail.FlightDetailID);
            /*
            FlightDetail flightDetail2 = _context.FlightDetails.Find(svm.FlightDetail2.FlightDetailID);

            ticket2.FlightDetail = flightDetail2;

            // Find the reservation
            Reservation res2 = _context.Reservations.Find(ticket.Reservation.ReservationID);
            ticket2.Reservation = res2;

            ticket2.User = await _userManager.FindByNameAsync(User.Identity.Name);

            ticket2.CustomerFirstName = ticket2.User.FirstName;
            ticket2.CustomerLastName = ticket2.User.LastName;
            ticket2.CustomerEmail = ticket2.User.Email;
            ticket2.CustomerDOB = ticket2.User.DOB;
            ticket2.CustomerAdvantageNum = ticket2.User.AdvantageNum;

            string DateOfBirth2 = ticket2.CustomerDOB.Substring(0, 2) + "/" + ticket2.CustomerDOB.Substring(2, 2) + "/" + ticket2.CustomerDOB.Substring(4, 2);
            DateTime DOB2 = DateTime.Parse(DateOfBirth2);
            
            foreach (Seat seat in FindAvailableSeats.GetAllSeats())
            {
                if (SelectedSeat == seat.SeatID)
                {
                    ticket2.SeatName = seat.Name;
                    ticket2.SeatFare = seat.FareType;
                }
            }
            Int32 age2 = DateTime.Now.Year - DOB2.Year;
            if (DateTime.Now.DayOfYear < DOB2.DayOfYear)
            {
                age2 = age2 - 1;
            }
            if (ticket2.SeatFare == FareType.Economy)
            {
                if (age2 <= 12)
                {
                    ticket2.Price = (ticket2.FlightDetail.BaseFare * (1 - CHILD_DISCOUNT));
                }
                else if (age2 >= 65)
                {
                    ticket2.Price = (ticket2.FlightDetail.BaseFare * (1 - SENIOR_DISCOUNT));
                }
                else
                {
                    ticket2.Price = ticket2.FlightDetail.BaseFare;
                }
            }
            else if (ticket2.SeatFare == FareType.First)
            {
                ticket2.Price = ticket2.FlightDetail.BaseFare * FIRST_CLASS;
            }

            */
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                //_context.Add(ticket2);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Reservations", new { id = ticket.Reservation.ReservationID });
            }


            ViewBag.AllSeats = GetAllSeats();
            return View(ticket);
        }

        //CreateOther GET
        public IActionResult CreateOther(Int32 reservationId, Int32 flightdetailID)
        {
            FlightDetail fd = _context.FlightDetails
                .Include(f => f.Flight.DepartingAirport).Include(f => f.Flight.ArrivingAirport)
                .FirstOrDefault(f => f.FlightDetailID == flightdetailID);

            Reservation r = _context.Reservations
                .FirstOrDefault(rs => rs.ReservationID == reservationId);

            TicketViewModel tvm = new TicketViewModel();
            tvm.FlightDetail = fd;
            tvm.Reservation = r;
            //tvm.DepartureSearch = fd.Flight.DepartingAirport.AirportID;
            //tvm.ArrivalSearch = fd.Flight.ArrivingAirport.AirportID;

            ViewBag.AllSeats = GetAllSeats();
            ViewBag.AllCustomers = GetAllCustomers();

            return View(tvm);
        }

        //POST: CreateOther
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOther([Bind("TicketID,CustomerFirstName,CustomerLastName,CustomerEmail,CustomerAdvantageNum,SeatName,Price,Reservation, FlightDetail")] int SelectedSeat, TicketViewModel tvm, int SelectedCustomer)
        {
            
  
            // Find the Flight Detail
            FlightDetail flightDetail = _context.FlightDetails.Find(tvm.FlightDetail.FlightDetailID);
            //FlightDetail flightDetail = _context.FlightDetails.Find(svm.FlightDetail.FlightDetailID);

            tvm.FlightDetail = flightDetail;

            // Find the reservation
            Reservation res = _context.Reservations.Find(tvm.Reservation.ReservationID);
            tvm.Reservation = res;

            //get user info
            AppUser user = _context.Users.FirstOrDefault(u => u.AdvantageNum == SelectedCustomer);
            //AppUser user = _context.Users.Find(SelectedUser);
            tvm.User = user;

            string DateOfBirth = tvm.User.DOB.Substring(0, 2) + "/" + tvm.User.DOB.Substring(2, 2) + "/" + tvm.User.DOB.Substring(4, 2);
            DateTime DOB = DateTime.Parse(DateOfBirth);

            foreach (Seat seat in FindAvailableSeats.GetAllSeats())
            {
                if (SelectedSeat == seat.SeatID)
                {
                    tvm.SeatName = seat.Name;
                    tvm.SeatFare = seat.FareType;
                }
            }
            Int32 age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
            {
                age = age - 1;
            }
            
            if (tvm.SeatFare == FareType.Economy)
            {
                if (age <= 12)
                {
                    tvm.Price = (tvm.FlightDetail.BaseFare * (1 - CHILD_DISCOUNT));
                }
                else if (age >= 65)
                {
                    tvm.Price = (tvm.FlightDetail.BaseFare * (1 - SENIOR_DISCOUNT));
                }
                else
                {
                    tvm.Price = tvm.FlightDetail.BaseFare;
                }
            }
            else if (tvm.SeatFare == FareType.First)
            {
                tvm.Price = tvm.FlightDetail.BaseFare * FIRST_CLASS;
            }
            
            Ticket ticket = new Ticket();
            ticket.Reservation = tvm.Reservation;

            ticket.FlightDetail = tvm.FlightDetail;
            //t.FlightDetail = fd;
            ticket.User = tvm.User;
            ticket.CustomerFirstName = tvm.User.FirstName;
            ticket.CustomerLastName = tvm.User.LastName;
            ticket.CustomerEmail = tvm.User.Email;
            ticket.CustomerAdvantageNum = tvm.User.AdvantageNum;
            ticket.CustomerDOB = tvm.User.DOB;
            ticket.SeatName = tvm.SeatName;
            ticket.SeatFare = tvm.SeatFare;

            

            ticket.Price = tvm.Price;

            ModelState.Clear();
            TryValidateModel(ticket);
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Reservations", new { id = ticket.Reservation.ReservationID });
            }

            ViewBag.AllSeats = GetAllSeats();
            ViewBag.AllCustomers = GetAllCustomers();
            return View(tvm);

        }


        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketID,CustomerFirstName,CustomerLastName,CustomerEmail,CustomerAdvantageNum,SeatName,Price")] Ticket ticket)
        {
            if (id != ticket.TicketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketID))
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
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.TicketID == id);
        }

        private SelectList GetAllFlightDetails()
        {
            List<FlightDetail> AllFlightDetails = _context.FlightDetails.ToList();

            SelectList flightDetails = new SelectList(AllFlightDetails, "FlightDetailID");

            return flightDetails;
        }

        private SelectList GetAllSeats()
        {
            List<Seat> AllSeats = FindAvailableSeats.GetAllSeats().ToList();

            Seat NoSeat = new Seat() { SeatID = 0, Name = "Select Seat"};
            AllSeats.Add(NoSeat);

            SelectList seats = new SelectList(AllSeats.OrderBy(t => t.SeatID), "SeatID", "Name");

            return seats;
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
            SelectList slAllUsers = new SelectList(AllUsers.OrderBy(u => u.UserName), "AdvantageNum", "UserName");

            //return the select list you just created
            return slAllUsers;
        }
        

        /*
        public async Task<SelectList> GetAllCustomersAsync()
        {
            //find all the users in the role
            var customerQuery = await _userManager.GetUsersInRoleAsync("Customer");
            //convert from task to list
            List<AppUser> customers = new List<AppUser>(customerQuery);

            //AppUser NoUser = new AppUser() { AdvantageNum = 0, UserName = "Select A User" };
            //customers.Add(NoUser);

            SelectList AllCustomers = new SelectList(customers, "AdvantageNum", "CustomerName");
            return AllCustomers;
        }

        public SelectList GetAllCustomers()
        {
            var list = GetAllCustomersAsync();
            SelectList sl = list.Result;
            return sl;
        }
        */

    }
}
