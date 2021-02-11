using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantsOfProvo.Models
{
    public class Restaurants
    {
        public Restaurants(int restaurantsranking)
        {
            RestaurantsRanking = restaurantsranking;
        }

        //variables
        public int RestaurantsRanking { get; }
        public string RestaurantsName { get; set; }
        #nullable enable
        public string? RestaurantsFavDish { get; set; }
        #nullable disable
        public string RestaurantsAddress { get; set; }
        #nullable enable
        public string RestaurantsPhone { get; set; }
        #nullable disable
        public string RestaurantsWebsite { get; set; } = "Coming soon";
        #nullable disable

        //fills out the array with 5 restaurants information
        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants(1)
            {
                 
                RestaurantsName = "Nico's Pizza",
                RestaurantsFavDish = "Slice of Cheese Pizza",
                RestaurantsAddress = "255 W Cougar Blvd, Provo, UT 84604",
                RestaurantsPhone = "(801) 356 - 7900"
            };

            Restaurants r2 = new Restaurants(2)
            {
                RestaurantsName = "Costa Vida",
                RestaurantsFavDish = "Regular Pork Salad",
                RestaurantsAddress = "1200 N University Ave, Provo, UT 84606",
                RestaurantsPhone = "(801) 373 - 1876",
                RestaurantsWebsite = "costavida.com"
            };

            Restaurants r3 = new Restaurants(3)
            {
                RestaurantsName = "Noodles and Company",
                RestaurantsFavDish = "Pesto Cavatappi",
                RestaurantsAddress = "62 West Bulldog Blvd, Provo, UT 84604",
                RestaurantsPhone = "(801) 373-9670",
                RestaurantsWebsite = "noodles.com"
            };

            Restaurants r4 = new Restaurants(4)
            {
                RestaurantsName = "Jdawgs",
                RestaurantsFavDish = null,
                RestaurantsAddress = "858 700 E, Provo, UT 84606",
                RestaurantsPhone = "(801) 373-3294",
                RestaurantsWebsite = "jdawgs.com"
            };

            Restaurants r5 = new Restaurants(5)
            {
                RestaurantsName = "Waffle Love",
                RestaurantsFavDish = "CinnaLove Waffle",
                RestaurantsAddress = "1831 N State St, Provo, UT 84604",
                RestaurantsPhone = "(801) 923 - 3588",
                RestaurantsWebsite = "waffluv.com"
            };
            //fills the array with the restaurant objects
            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
