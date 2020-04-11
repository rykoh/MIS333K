using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Kohanski_Ryan_HW4.Controllers;

namespace Kohanski_Ryan_HW4.Models.ViewModels
{
    // View Model for Detailed Search
    // A ViewModel is a model class that is, by definition, NOT stored in the database
    // it is a model created specifically for a particular view
    // The most important difference between a ViewModel and a regular model (also known as a domain model) is that you don’t create a DbSet for ViewModels in your AppDbContext class.
    // create a property for each criteria you will need for search
    // Advanced search should be an “AND” search
    // If the selected criteria don’t result in any movies, just display “0 out of X movies” and leave the table headers.  You don’t need to display anything special for this case.

    public class SearchViewModel
    {
        //Title – a textbox to allow the user to search the title field.
        [Display(Name = "Search Movie Title:")]
        public String TitleSearch { get; set; }

        //Description – a textbox to allow the user to search the description field
        [Display(Name = "Search Description:")]
        public String DescriptionSearch { get; set; }

        //Genre (Int because it maps to a GenreID)
        //a drop-down list that allows the user to select the desired genre
        //The user can only select a single genre from this list. 
        //Be sure to include an “all genres” option if the user does not want to include genre in their search.
        [Display(Name = "Select a Genre:")]
        public Int32 GenreSearch { get; set; }

        //Rating - a combination of a textbox for the desired rating and two radio buttons
        //The radio buttons allow the user to search for “Greater Than” or “Less Than” the amount in the box
        // Greater than AND equal to or less than AND equal to
        //Make sure to check to see if the value in the textbox is a valid number.
        [Display(Name = "Rating:")]
        public Decimal? RatingSearch { get; set; }

        //Greater Than Less Than For Rating
        public SelectionType? SelectionType { get; set; }

        //Released After – a date picker that will allow the user to select a date.
        //The search should return any movies that were released ON OR AFTER the selected date. 
        //DateTime? means this date is nullable - we want to allow them to be able to NOT select a date
        [Display(Name = "Released After:")]
        [DataType(DataType.Date)]
        public DateTime? DateSearch { get; set; }
    }
}
