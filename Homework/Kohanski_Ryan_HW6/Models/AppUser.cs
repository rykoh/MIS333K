using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Kohanski_Ryan_HW6.Models
{
    public class AppUser : IdentityUser
    {
        //Identity creates several of the important fields for you
        //Full documentation of the IdentityUser class can be found at
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identityuser?view=aspnetcore-1.1&viewFallbackFrom=aspnetcore-2.1
        //Identity uses a built-in User class that already has several fields that all applications need (UserID, Email, Phone Number)

        //Put any additional fields that you need for your user here

        //USER ID
        //Id – use the built-in Identity field for the unique identifier for the user. This is the primary key for this model class.  

        //FIRST NAME
        //Identity does not automatically create this field in the user table
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        //LAST NAME
        //Identity does not automatically create this field in the user table
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //EMAIL
        //Use the built-in Identity field for this.  Email will also be the user’s username. Required.


        //PHONE NUMBER
        //Use the built-in Identity field for this. Required.



        //All other fields (passwords, roles, etc.) will be inherited from the IdentityUser class.  
        //See https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identityuser for more information about this base class.


        //Navigational Properties
        public List<Order> Orders { get; set; }
    }
}