using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantsOfProvo.Models;

namespace RestaurantsOfProvo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //displayed on welcome (index) page, is the list of 5 provo restaurants
        public IActionResult Index()
        {
            List<string> TopRestaurants = new List<string>();

            foreach (Restaurants r in Restaurants.GetRestaurants())
            {
                //allows for some variables to be left blank
                #nullable enable
                string? RestaurantsFavDish = r.RestaurantsFavDish ?? "It's all tasty!";
                string? RestaurantsPhone = r.RestaurantsPhone;
                string? RestaurantsWebsite = r.RestaurantsWebsite;
                #nullable disable

                TopRestaurants.Add(string.Format("{0}: {1} || {2} || {3} || {4} || {5}", r.RestaurantsRanking, r.RestaurantsName, RestaurantsFavDish, r.RestaurantsAddress, RestaurantsPhone, RestaurantsWebsite));
            }

            return View(TopRestaurants);
        }

       //add a restaurant get form
        [HttpGet]
        public IActionResult AddRestForm()
        {
            return View();
        }

        //adds a restaurant and sends the user to the confimation page
        [HttpPost]
        public IActionResult AddRestForm(ApplicationResponse appResponse)
        {
            TempStorage.Addapplication(appResponse);
            return View("Confirmation",appResponse);
        }

        //displays all the entered restaurants
        public IActionResult EnteredRestaurants()
        {
            return View(TempStorage.Applications);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
