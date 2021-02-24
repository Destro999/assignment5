using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment5.Models
{
    //all fields are required and the first one is a Key and an auto number
    public class Project
    {
        [Key, Required]
        public int BookKey { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        //Regex Expression requiring the ISBN to be correct
        [Required, RegularExpression(@"ISBN\x20(?=.{13}$)\d{1,5}([- ])\d{1,7}\1\d{1,6}\1(\d|X)$")]
        public long ISBN { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Pages { get; set; }
    }

}
