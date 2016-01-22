using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using angularNorthwind.Models;
using angularNorthwind.ViewModel;

namespace angularNorthwind.Controllers
{
    public class OrdersController : ApiController
    {
        private Northwind db = new Northwind();

        // GET: api/Orders
        [Route("api/orders")]
        public async Task<List<OrderVM>> GetOrders()
        {
            List<OrderVM> vmList = new List<OrderVM>();
            //var orders = await db.Orders.Where(x=>x.ShipCountry == "USA").ToListAsync();
            var orders = await db.Orders.ToListAsync();
            foreach (Order order in orders)
            {
                vmList.Add(order);
            }

            return vmList;
        }

        // GET: api/Orders/5
        [Route("api/orders/{orderId}")]
        public async Task<OrderVM> GetOrder(int orderId)
        {
            Order order = await db.Orders.FindAsync(orderId);
            if (order == null)
            {
                throw new HttpResponseException(
                    Request.CreateErrorResponse(
                        HttpStatusCode.NotFound,
                        "Order Id: " + orderId + " was not found."));
            }

            OrderVM vm = order;

            return vm;
        }

        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderID)
            {
                return BadRequest();
            }

            db.Entry(order).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = order.OrderID }, order);
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> DeleteOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.OrderID == id) > 0;
        }
    }
}