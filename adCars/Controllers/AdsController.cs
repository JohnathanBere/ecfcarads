using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using adCars.Models;
using adCars.ViewModels;

namespace adCars.Controllers
{
    public class AdsController : Controller
    {
        /* public ActionResult Index()
        {
            var ad = new Ad() {CarMake = "Bugati"};
            var customers = new List<Customer>()
            {
                new Customer {Name = "Phillis"},
                new Customer {Name = "Regis"}
            };

            var viewModel = new AdsViewModel
            {
                Ad = ad,
                Customers = customers
            };

            return View(viewModel);
        } */

        public ViewResult Index()
        {
            var ads = GetAds();
            return View(ads);
        }

        private IEnumerable<Ad> GetAds()
        {
            return new List<Ad>
            {
                new Ad {CarMake = "Bugati"},
                new Ad {CarMake = "Lamborghini"}
            };
        }


    }
}