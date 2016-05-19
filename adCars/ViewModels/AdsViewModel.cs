using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using adCars.Models;

namespace adCars.ViewModels
{
    public class AdsViewModel
    {
        public Ad Ad { get; set; }
        public List<Customer> Customers { get; set; }
    }
}