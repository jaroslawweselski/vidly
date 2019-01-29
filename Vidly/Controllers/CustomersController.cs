﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {

            var viewModel = new CustomerViewModel { Customers = this.GetCustomers() };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = this.GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Due" },
                new Customer { Id = 2, Name = "Jane Due" }
            };
        }
    }
}