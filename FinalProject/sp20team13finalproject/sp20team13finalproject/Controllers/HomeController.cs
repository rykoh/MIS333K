using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;
using Microsoft.EntityFrameworkCore;
using sp20team13finalproject.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sp20team13finalproject.Controllers
{
    public enum PaymentType { Card, Miles }

    public enum TripType { OneWay, RoundTrip }

    public enum EmpType { None, Pilot, CoPilot, FlightAttendant }

    public enum FlightStatus { OnTime, Departed, Cancelled }
    public class HomeController : Controller
    {

        // Add the code to hold an instance of your AppDbContext in a private variable and the constructor to populate it
        private AppDbContext _db;
        public HomeController(AppDbContext context)
        {
            _db = context;
        }

        // SEARCH DEPARTING FLIGHTS
        // Quick Search
        // you don’t need to include the ? to make it nullable (Strings are inherently nullable).
        public IActionResult Index(String DepString, String ArrivalString)
        {
            //return View(_db.Movies.Include(m => m.Genre).ToList());

            // Create a LINQ query to filter the flights you want
            var query = from fd in _db.FlightDetails
                        select fd;


            // Check to see if SearchString is null.  If it is, it is the first time they opened the page or they didn’t search for anything.
            // If SearchString is null, display all the records.  If the search string is not null, use LINQ to limit the query to movies whose author or title contain the requested string

            // Only Departing Flights
            if ((DepString != null && DepString != "") && (ArrivalString == null || ArrivalString == ""))
            {
                query = query.Where(fd => fd.Flight.DepCity.Contains(DepString));
            }
            // Only Arriving Flights
            else if ((ArrivalString != null && ArrivalString != "") && (DepString == null || DepString == ""))
            {
                query = query.Where(fd => fd.Flight.ArrivalCity.Contains(ArrivalString));
            }
            // Both Flights
            else if ((DepString != null && DepString != "") && (ArrivalString != null && ArrivalString != ""))
            {
                query = query.Where(fd => fd.Flight.DepCity.Contains(DepString) && fd.Flight.ArrivalCity.Contains(ArrivalString));
            }

            query = query.Where(fd => fd.flightStatus == FlightDetail.FlightStatus.OnTime);

            //execute the query
            // Use the .ToList() method to execute the query
            List<FlightDetail> SelectedFlightDetails = query.Include(fd => fd.Flight).ToList();


            //Populate the counts for all books & selected books
            // puts the total movie count in the ViewBag.  (Hint: the List object has a .Count method)
            // Add the total movies count and the selected movie count for to the view bag so the results page will show “Showing X of Y Movies”
            ViewBag.AllFlightDetailsCount = _db.FlightDetails.Count();
            ViewBag.SelectedFlightDetailsCount = SelectedFlightDetails.Count();

            return View(SelectedFlightDetails.OrderBy(fd => fd.Date));
        }


        public IActionResult DetailedSearch(Int32 reservationId)
        {
            /*
            if (reservationId != 0)
            {
                Reservation r = _db.Reservations
                    .FirstOrDefault(rs => rs.ReservationID == reservationId);

                ViewBag.AllCities = GetAllCities();
                ViewBag.AllDepTimes = GetAllDepTimes();

                return View(r);
            }
            */
            //populate the drop-down of Times and Cities
            ViewBag.AllCities = GetAllCities();
            ViewBag.AllDepTimes = GetAllDepTimes();

            return View();
        }

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            //if svm.Trip
            var query = from fd in _db.FlightDetails
                        select fd;

            // Search Departure City
            if (svm.DepartureSearch != 0) //user wants to search by name
            {
                query = query.Where(fd => fd.Flight.DepartingAirport.AirportID == svm.DepartureSearch);
            }
            // Search Arrival City
            if (svm.ArrivalSearch != 0)
            {
                query = query.Where(fd => fd.Flight.ArrivingAirport.AirportID == svm.ArrivalSearch);
            }

            // Search Number of Passengers
            // TODO: figure this out
            if (svm.NumPassSearch > 0)
            {
                query = query.Where(fd => fd.SeatsLeft > svm.NumPassSearch);
            }

            // TODO: fix arrival date (one day less than input)
            // Search Both Dates
            if (svm.StartDateSearch != null & svm.EndDateSearch != null)
            {
                query = query.Where(fd => fd.Date >= svm.StartDateSearch & fd.Date <= svm.EndDateSearch);
            }
            // Search Departure Date Only
            if (svm.StartDateSearch != null & svm.EndDateSearch == null)
            {
                query = query.Where(fd => fd.Date >= svm.StartDateSearch);
            }
            // Search Arrival Date Only
            if (svm.StartDateSearch == null & svm.EndDateSearch != null)
            {
                query = query.Where(fd => fd.Date <= svm.EndDateSearch);
            }
            // Search Departure Time
            if (svm.StartTimeSearch != 0)
            {
                query = query.Where(fd => fd.Flight.FlightID > svm.StartTimeSearch);
            }

            query = query.Where(fd => fd.flightStatus == FlightDetail.FlightStatus.OnTime);
            // TODO: include end time for range??

            if (svm.tripType == SearchViewModel.TripType.OneWay)
            {
                query = query.Where(fd => fd.Flight.ArrivingAirport.AirportID == svm.ArrivalSearch & fd.Flight.DepartingAirport.AirportID == svm.DepartureSearch);
                List<FlightDetail> SelectedFlightDetails = query.Include(fd => fd.Flight).ToList();

                SelectedFlightDetails.OrderBy(fd => fd.Date);

                ViewBag.AllFlightDetailsCount = _db.FlightDetails.Count();
                ViewBag.SelectedFlightDetailsCount = SelectedFlightDetails.Count();

                return View("SearchResults", SelectedFlightDetails);
            }

            else if (svm.tripType == SearchViewModel.TripType.RoundTrip)
            {
                query = query.Where(fd => fd.Flight.ArrivingAirport.AirportID == svm.ArrivalSearch & fd.Flight.DepartingAirport.AirportID == svm.DepartureSearch);
                List<FlightDetail> SelectedFlightDetails = query.Include(fd => fd.Flight).ToList();

                SelectedFlightDetails.OrderBy(fd => fd.Date);

                ViewBag.AllFlightDetailsCount = _db.FlightDetails.Count();
                ViewBag.SelectedFlightDetailsCount = SelectedFlightDetails.Count();

                return View("RoundTrip", SelectedFlightDetails);
            }
            return View();

        }

        
        public IActionResult RoundTrip(Int32 flightDetailID2)
        {
            SearchViewModel svm = new SearchViewModel();
            FlightDetail fd = _db.FlightDetails
                .Include(f => f.Flight.DepartingAirport).Include(f => f.Flight.ArrivingAirport)
                .FirstOrDefault(f => f.FlightDetailID == flightDetailID2);

            svm.DepartureSearch = fd.Flight.DepartingAirport.AirportID;
            svm.ArrivalSearch = fd.Flight.ArrivingAirport.AirportID;
            svm.NumPassSearch = 1;
            svm.StartDateSearch = fd.Date;
            svm.EndDateSearch = new DateTime(2020, 6, 30, 0, 0, 0);
            svm.StartTimeSearch = 0;
            svm.tripType = SearchViewModel.TripType.RoundTrip;
            svm.FlightDetail = fd;

            
            //if svm.Trip
            var query = from fds in _db.FlightDetails
                        select fds;

            // Search Departure City
            if (svm.DepartureSearch != 0) //user wants to search by name
            {
                query = query.Where(fds => fds.Flight.DepartingAirport.AirportID == svm.DepartureSearch);
            }
            // Search Arrival City
            if (svm.ArrivalSearch != 0)
            {
                query = query.Where(fds => fds.Flight.ArrivingAirport.AirportID == svm.ArrivalSearch);
            }
            // Search Number of Passengers
            // TODO: figure this out
            if (svm.NumPassSearch > 0)
            {
                query = query.Where(fds => fds.SeatsLeft > svm.NumPassSearch);
            }

            // TODO: fix arrival date (one day less than input)
            // Search Both Dates
            if (svm.StartDateSearch != null)
            {
                query = query.Where(fds => fds.Date > svm.StartDateSearch);
            }


            query = query.Where(fds => fds.Flight.ArrivingAirport.AirportID == svm.DepartureSearch & fds.Flight.DepartingAirport.AirportID == svm.ArrivalSearch);

            List<FlightDetail> SelectedFlightDetails = query.Include(fds => fds.Flight).ToList();

            SelectedFlightDetails.OrderBy(fds => fds.Date);

            ViewBag.AllFlightDetailsCount = _db.FlightDetails.Count();
            ViewBag.SelectedFlightDetailsCount = SelectedFlightDetails.Count();

            return View("SearchResults2", SelectedFlightDetails);

            }
            
    



        // Drop Down List For Cities
        public SelectList GetAllCities()
            {
                List<Airport> AllCities = _db.Airports.ToList();

                //Add a fake genre to allow user to select nothing
                Airport NoCity = new Airport() { AirportID = 0, City = "All Cities" };
                AllCities.Add(NoCity);

                //Turn this into a select list
                SelectList slAllCities = new SelectList(AllCities.OrderBy(c => c.AirportID), "AirportID", "City");

                //return the select list you just created
                return slAllCities;
            }

        // Drop Down List For Departure Times
        public SelectList GetAllDepTimes()
        {
            List<Flight> AllDepTimes = _db.Flights.ToList();

            //Add a fake genre to allow user to select nothing
            Flight NoDepTime = new Flight() { FlightID = 0, DepTime = TimeSpan.Parse("00:00:00") };
            AllDepTimes.Add(NoDepTime);

            //Turn this into a select list
            SelectList slAllDepTimes = new SelectList(AllDepTimes.OrderBy(t => t.DepTime), "FlightID", "DepTime");

            //return the select list you just created
            return slAllDepTimes;
        }

    }
}
 

