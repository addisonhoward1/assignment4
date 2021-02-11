using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsOfProvo.Models
{
    //allows users to enter restaurants but not be connected to a databse
    //resets everytime the they live the site
    public static class TempStorage
    {
        private static List<ApplicationResponse> applications = new List<ApplicationResponse>();

        public static IEnumerable<ApplicationResponse> Applications => applications;

        public static void Addapplication(ApplicationResponse application)
        {
            applications.Add(application);
        }
    }
}