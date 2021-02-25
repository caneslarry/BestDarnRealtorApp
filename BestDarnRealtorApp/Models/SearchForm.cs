using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestDarnRealtorApp.Models
{
    public class SearchForm
    {
        [MaxLength(50)]
        public string mls { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        [Range(0, 20, ErrorMessage = "Please use values between 1 to 20")]
        public int bedrooms_min { get; set; }

        [Range(0, 20, ErrorMessage = "Please use values between 1 to 20")]
        public int bedrooms_max { get; set; }

        [Range(0, 10, ErrorMessage = "Please use values between 1 to 10")]
        public int bathrooms_min { get; set; }

        [Range(0, 10, ErrorMessage = "Please use values between 1 to 10")]
        public int bathrooms_max { get; set; }

        [Range(0, 20, ErrorMessage = "Please use values between 1 to 20000")]
        public int squarefeet_min { get; set; }

        [Range(0, 20, ErrorMessage = "Please use values between 1 to 20000")]
        public int squarefeet_max { get; set; }

        public IEnumerable<Listing> Listings;

        public SearchForm()
        {
        }
    }
}
