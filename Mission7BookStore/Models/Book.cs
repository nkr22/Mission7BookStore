using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mission7BookStore.Models
{
    public partial class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Please enter a book title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter an author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter a publisher")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Please enter an ISBN Number")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "Please specify a classification")]
        public string Classification { get; set; }
        [Required(ErrorMessage = "Please specify an category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter a page count")]
        public int PageCount { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        public float Price { get; set; }
    }
}








