using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantsOfProvo.Models
{
    public class ApplicationResponse
    {
        //defines all the variables for the users to enter
        public string Name { get; set; }

        public string RestaurantName { get; set; }

        public string FavDish { get; set; }

        //doesn't allow users to enter an invalid phone number
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string Phone { get; set; }


    }
}
