using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

//TODO: Make this namespace match your project
namespace Kohanski_Ryan_HW4.Models
{
    public class AppUser : IdentityUser
    {
        //Identity creates several of the important fields for you
        //TODO: Put any additional fields that you need for your user here (You don't need this for HW4)
        //First name is provided as an example
        //[Required(ErrorMessage = "First name is required.")]
        //[Display(Name = "First Name")]
        //public String FirstName { get; set; }
    }
}