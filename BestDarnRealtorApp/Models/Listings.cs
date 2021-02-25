using System;
using System.ComponentModel.DataAnnotations;

namespace BestDarnRealtorApp.Models
{
    public class Listing
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Mls { get; set; }

        [Required]
        public string Street1 { get; set; }

        public string Street2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string Zip { get; set; }

        public string Neighborhood { get; set; }

        [Required]
        [Range(1, 200000000, ErrorMessage = "Please use values between 1 to 20,0000,000")]
        public float SalesPrice { get; set; }

        [Required]
        public DateTime DateListed { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Please use values between 1 to 20")]
        public float Bedrooms { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Please use values between 1 to 10")]
        public float Bathrooms { get; set; }

        [Range(1, 20, ErrorMessage = "Please use values between 1 to 20")]
        public int GarageSize { get; set; }

        [Required]
        [Range(1, 20000, ErrorMessage = "Please use values between 1 to 20,000")]
        public int SquareFeet { get; set; }

        [Range(1, 200000, ErrorMessage = "Please use values between 1 to 200,000")]
        public int LotSize { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }

        public Listing()
        {
        }
    }
}
