//Author: Ryan Kohanski
//Date: 2/20/20
//Assignment: Homework 3
//Description: OOP Food Truck Checkout

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kohanski_Ryan_HW3.Models;
using Microsoft.AspNetCore.Mvc;
using static Kohanski_Ryan_HW3.Models.Order;

namespace Kohanski_Ryan_HW3.Controllers
{
    public class HomeController : Controller
    {
        //METHODS
        //Index
        //Display the Index view (Views/Home/Index.cshtml)
        public IActionResult Index()
        {
            return View();
        }

        //CheckoutCatering
        //Display the CheckoutCatering view (Views/Home/CheckoutCatering.cshtml)
        public IActionResult CheckoutCatering()
        {
            return View("CheckoutCatering");
        }

        //CateringTotals
        //Parameters: CateringOrder – object that contains the values for the catering order
        public IActionResult CateringTotals(CateringOrder cateringOrder)
        {
            TryValidateModel(cateringOrder);

            if (ModelState.IsValid == false)
            {
                return View("CheckoutCatering", cateringOrder);
            }
            else
            {
                cateringOrder.customerType = CustomerType.Catering;

                cateringOrder.CalcTotals(cateringOrder.DeliveryFee);

                return View("CateringTotals", cateringOrder);
            }
        }

        //CheckoutWalkup
        //Display the CheckoutWalkup view (Views/Home/CheckoutWalkup.cshtml)
        public IActionResult CheckoutWalkup()
        {
            return View("CheckoutWalkup");
        }

        //WalkupTotals
        //Parameters: walkupOrder – object that contains the values for the walkup order
        public IActionResult WalkupTotals(WalkupOrder walkupOrder)
        {
            TryValidateModel(walkupOrder);

            if (ModelState.IsValid == false)
            {
                return View("CheckoutWalkup", walkupOrder);
            }
            else
            {
                walkupOrder.customerType = CustomerType.Walkup;

                walkupOrder.CalcTotals();

                return View("WalkupTotals", walkupOrder);
            }
        }


    }
}