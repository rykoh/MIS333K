using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kohanski_Ryan_HW4.Models
{
    public class Genre
    {
        [Display(Name ="Genre ID")]
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        public String GenreName { get; set; }

        //navigational properties
        public List<Movie> Movies { get; set; }
    }
}
