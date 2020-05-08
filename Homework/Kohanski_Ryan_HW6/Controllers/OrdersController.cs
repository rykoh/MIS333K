﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kohanski_Ryan_HW6.DAL;
using Kohanski_Ryan_HW6.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Kohanski_Ryan_HW6.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrdersController(AppDbContext context, IServiceProvider service)
        {
            _context = context;
            _userManager = service.GetRequiredService<UserManager<AppUser>>();
        }

        // GET: Orders
        public IActionResult Index()
        {
            //get all the registrations from the database and include the registration details
            List<Order> orders = new List<Order>();
            if (User.IsInRole("Admin"))
            {
                orders = _context.Orders.Include(o => o.OrderDetails).ToList();
            }
            else //user is customer
            {
                orders = _context.Orders.Where(o => o.User.UserName == User.Identity.Name).Include(o => o.OrderDetails).ToList();
            }

            return View(orders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //update this statement to have an include clause to get the registration details
            //and course information
            Order order = await _context.Orders
                .Include(o => o.OrderDetails).ThenInclude(o => o.Product)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);

            if (order == null) //registration not found
            {
                return View("Error", new String[] { "Cannot find this order!" });
            }

            if (User.IsInRole("Admin") == false && order.User.UserName != User.Identity.Name) //they are trying to see something that isn't theirs
            {
                return View("Error", new String[] { "Unauthorized: You are attempting to view another customer's order!" });
            }

            return View(order);
        }

        // GET: Orders/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create([Bind("OrderID,OrderNumber,OrderDate,OrderNotes")] Order order)
        {
            order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);
            order.OrderDate = DateTime.Now;

            //Get the user who is logged in
            order.User = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();

                //update the redirect here to go to the create order detail page
                return RedirectToAction("Create", "OrderDetails", new { orderId = order.OrderID });
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify the order you wish to edit!" });
            }

            //update the query to add an include clause to get registration detail info
            Order order = _context.Orders
                .Include(o => o.OrderDetails).ThenInclude(o => o.Product)
                .Include(o => o.User)
                .FirstOrDefault(ord => ord.OrderID == id);
            if (order == null)
            {
                return View("Error", new String[] { "Cannot find the order you wish to edit!" });
            }

            if (User.IsInRole("Admin") == false && order.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "Unauthorized: You are attempting to edit another customer's order!" });
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,OrderNumber,OrderDate,OrderNotes")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Order DBOrd = _context.Orders.Find(order.OrderID);
                    DBOrd.OrderNotes = order.OrderNotes;
                    _context.Update(DBOrd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
        /*
        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }
}
