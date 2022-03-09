using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7BookStore.Models
{
    public class Checkout
    {
        [Key]
        //information that cannot be passed in the URL
        [BindNever]
        public int CheckoutId { get; set; }
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage ="Please enter a name. ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the first address line. ")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage = "Please enter a City. ")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a State. ")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage ="Please enter a Country. ")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please mark whether this is Anonymous")]
        public bool Anonymous { get; set; } = false;
        [BindNever]
        public bool Shipped { get; set; } = false;
    }
}
