using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

// Each movie has been assigned a single genre.  There is a one-to-many relationship between genres and movies - a movie is associated with a single genre, and a genre can be associated with many movies.  

namespace Kohanski_Ryan_HW4.Models
{
    public class Movie
    {
        [Display(Name = "Movie ID")]
        public Int32 MovieID { get; set; }

        [Display(Name = "IMDB ID")]
        public String IMDBID { get; set; }

        public String Title { get; set; }
        public String Description { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Average Rating")]
        public Decimal VoteAverage { get; set; }

        [Display(Name = "# of Votes")]
        [DisplayFormat(DataFormatString ="{0:n0}")]
        public Int32 VoteCount { get; set; }

        [Display(Name = "Website")]
        public String URL { get; set; }

        //navigational property
        public Genre Genre { get; set; }

    }
}
