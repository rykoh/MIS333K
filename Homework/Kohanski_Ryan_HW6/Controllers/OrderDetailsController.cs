using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kohanski_Ryan_HW6.DAL;
using Kohanski_Ryan_HW6.Models;

namespace Kohanski_Ryan_HW6.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        public IActionResult Index(Int32 orderID)
        {
            List<OrderDetail> ods = _context.OrderDetails
                .Include(od => od.Product)
                .Where(o => o.Order.OrderID == orderID).ToList();
            return View(ods);
        }

        // GET: OrderDetails/Create
        public IActionResult Create(Int32 orderID)
        {
            OrderDetail od = new OrderDetail();
            od.Order = _context.Orders.Find(orderID);
            ViewBag.AllProducts = GetAllProducts();

            //make sure you pass the newly created registration detail to the view
            return View(od);
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailID,OrderQuantity,ProductPrice,ExtendedPrice,Order")] OrderDetail orderDetail, int SelectedProduct)
        {
            //find the correct course
            Product product = _context.Products.Find(SelectedProduct);
            orderDetail.Product = product;

            //find the correct registration
            Order ord = _context.Orders.Find(orderDetail.Order.OrderID);
            orderDetail.Order = ord;

            //set the registration detail price equal to the course price
            orderDetail.ProductPrice = product.ProductPrice;

            //calculate the total price
            orderDetail.ExtendedPrice = orderDetail.ProductPrice * orderDetail.OrderQuantity;


            if (ModelState.IsValid)
            {
                _context.Add(orderDetail);
                await _context.SaveChangesAsync();

                //modify the redirect to action to take you to the registration details page
                return RedirectToAction("Details", "Orders", new { id = orderDetail.Order.OrderID });
            }
            //re-populate the view bag in case the data is not valid
            ViewBag.AllProducts = GetAllProducts();
            return View(orderDetail);
        }

        // GET: OrderDetails/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetail orderDetail = _context.OrderDetails
                .Include(p => p.Product)
                .Include(p => p.Order)
                .FirstOrDefault(od => od.OrderDetailID == id);

            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("OrderDetailID,OrderQuantity,ProductPrice")] OrderDetail orderDetail)
        {
            //find the existing registration detail in the database
            //include both registration and course
            OrderDetail dbOD = _context.OrderDetails
                .Include(od => od.Product)
                .Include(od => od.Order)
                .FirstOrDefault(o => o.OrderDetailID == orderDetail.OrderDetailID);

            //update the scalar properties
            dbOD.OrderQuantity = orderDetail.OrderQuantity;
            dbOD.ProductPrice = dbOD.Product.ProductPrice;
            dbOD.ExtendedPrice = dbOD.OrderQuantity * dbOD.ProductPrice;

            //save changes
            if (ModelState.IsValid)
            {
                _context.Update(dbOD);
                _context.SaveChanges();
                //redirect to Registrations/Details
                return RedirectToAction("Details", "Orders", new { id = dbOD.Order.OrderID });
            }

            return View(dbOD);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetail orderDetail = await _context.OrderDetails
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //update this query to include registration so you can redirect to the
            //correct registration page
            OrderDetail orderDetail = _context.OrderDetails
                .Include(ord => ord.Order)
                .FirstOrDefault(o => o.OrderDetailID == id);
            Order od = orderDetail.Order;
            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();

            //update this redirect statement to send user back to details
            return RedirectToAction("Details", "Orders", new { id = od.OrderID });
        }

        private bool OrderDetailExists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailID == id);
        }

        //method to create the select list for the products drop-down
        private SelectList GetAllProducts()
        {
            //get a list of all courses from the database
            List<Product> AllProducts = _context.Products.ToList();

            //convert this to a select list
            //note that CourseID and CourseName are the names of fields in the Course model class
            SelectList products = new SelectList(AllProducts, "ProductID", "ProductName");

            //return the select list
            return products;

        }
    }
}
