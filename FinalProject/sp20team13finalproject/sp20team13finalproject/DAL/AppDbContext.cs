using System;
using Microsoft.EntityFrameworkCore;

//TODO: Update this using statement to include your project name
using sp20team13finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: Make this namespace match your project name
namespace sp20team13finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }


        // No dbset for User Class (Included In Identity)

        // Reservation Table
        public DbSet<Reservation> Reservations { get; set; }

        // Ticket Table
        public DbSet<Ticket> Tickets { get; set; }

        // Flight Detail Table
        public DbSet<FlightDetail> FlightDetails { get; set; }

        // Flight Table
        public DbSet<Flight> Flights { get; set; }

        // AIrport Detail
        public DbSet<Airport> Airports { get; set; }
    }
}
