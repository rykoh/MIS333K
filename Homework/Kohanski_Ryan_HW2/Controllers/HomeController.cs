//Author: Ryan Kohanski
//Date: 2/13/20
//Assignment: Homework 2
//Description: Food Truck Checkout

using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Kohanski_Ryan_HW2.Controllers
{
    //Controller Class
    public class HomeController : Controller
    {
        //Show home page
        public IActionResult Index()
        {
            return View();
        }//end of method

        //Used to call validation methods and perform calculations
        public IActionResult Calculate(string strCode, string strTacos, string strSands) 
        {
            //Check the value of the customer code by calling the CheckName method
            Boolean bolCheckName = CheckName(strCode);

            if (bolCheckName == false)
            {
                ViewBag.ErrorMessage = "Customer code must be 2-4 characters.";

                return View("Index");
            }

            Int32 intTacos;

            //check the value of the Tacos by calling the CheckItems method
            try
            {
                intTacos = CheckItems(strTacos);
            }
            catch (Exception ex) 
            {
                ViewBag.ErrorMessage = ex.Message;

                return View("Index");
            }

            Int32 intSands;

            //check the value of the Sandwiches by calling the CheckItems method
            try
            {
                intSands = CheckItems(strSands);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;

                return View("Index");
            }

            //Calculations
            const Int32 intTacoPrice = 3; 
            const Int32 intSandPrice = 5; 
            Int32 intItemsRequested = intTacos + intSands;
            Double dblTacoSubtotal = intTacos * intTacoPrice; 
            Double dblSandSubtotal = intSands * intSandPrice;
            Double dblSubtotal = dblTacoSubtotal + dblSandSubtotal;
            const Double dblTaxRate = .085;
            Double dblTax = dblSubtotal * dblTaxRate;
            Double dblTotal = dblSubtotal + dblTax;

            //Check if both boxes are empty
            if (intItemsRequested <= 0)
            {
                ViewBag.ErrorMessage = "You must purchase at least one item!";

                return View("Index");
            }

            //Viewbag statements used to display outputs on results page
            ViewBag.strCode = "Customer Code: " + strCode.ToUpper();
            ViewBag.intItemsRequested = "Items Requested: " + intItemsRequested;
            ViewBag.dblTacoSubtotal = "Taco Subtotal: " + dblTacoSubtotal.ToString("C");
            ViewBag.dblSandSubtotal = "Sandwiches Subtotal: " + dblSandSubtotal.ToString("C");
            ViewBag.dblSubtotal = "Subtotal: " + dblSubtotal.ToString("C");
            ViewBag.dblTax = "Tax: " + dblTax.ToString("C");
            ViewBag.dblTotal = "Total: " + dblTotal.ToString("C");

            return View("Results");
        }//end of method

        //Check the Customer Code
        public Boolean CheckName(string strInput)
        {
            if(String.IsNullOrEmpty(strInput))
            {
                return false;
            }
            if (strInput.All(char.IsLetter))
            {       
                if (strInput.Length < 2)
                {
                    return false;
                }
                if (strInput.Length > 4)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }//end of method

        //Check the items 
        public Int32 CheckItems(string strInput)
        {
            Int32 intResult;

            try
            { 
                intResult = Convert.ToInt32(strInput);
            }
            catch (Exception ex)
            {
                throw new Exception(strInput + " is not a valid integer!", ex);
            }

            return intResult;
        }//end of method
    }//end of class
}//end of namespace