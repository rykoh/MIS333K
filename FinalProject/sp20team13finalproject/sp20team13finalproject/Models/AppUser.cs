using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models
{
    public class AppUser : IdentityUser
    {
        // User ID (Set By Identity)

        // First Name 
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        // Middle Initial (Not Stored)

        // Last Name
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        // Date of Birth
        [Display(Name = "Date of Birth")]
        public String DOB { get; set; }

        // Address
        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public String Address { get; set; }

        // City
        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City")]
        public String City { get; set; }

        // State
        [Required(ErrorMessage = "State is required.")]
        [Display(Name = "State")]
        // TODO: Make drop down list
        public String State { get; set; }

        // Zip Code
        [Required(ErrorMessage = "Zip Code")]
        [Display(Name = "Zip Code")]
        public String Zip { get; set; }

        // Phone Number (Created By Identity)

        // Email Address (Created By Identity)

        // Account Miles
        [Display(Name = "Miles")]
        public Int32 Miles { get; set; }

        // Advantage Number
        // Advantage numbers start at 5000 and increase by 1
        [Display(Name = "Advantage Number")]
        public Int32 AdvantageNum { get; set; }

        // Employee Type (For Flight Crew Members)
        public enum EmpType
        {
            None, //0 NULL?
            Pilot, //1
            CoPilot, //2
            FlightAttendant //3
        }
        [Display(Name = "Employee Type")]
        public EmpType empType { get; set; }


        // Navigational Properties
        // (Reservation Table)
        public List<Reservation> Reservations { get; set; }
    }
}
