using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using angularNorthwind.Models;

namespace angularNorthwind.ViewModel
{
    public class OrderVM
    {
        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }

        public static implicit operator OrderVM(Order order)
        {
            return new OrderVM()
            {
                CustomerID = order.CustomerID,
                EmployeeID = order.EmployeeID,
                Freight = order.Freight,
                OrderDate = order.OrderDate,
                OrderID = order.OrderID,
                RequiredDate = order.RequiredDate,
                ShipAddress = order.ShipAddress,
                ShipCity = order.ShipCity,
                ShipCountry = order.ShipCountry,
                ShipName = order.ShipName,
                ShippedDate = order.ShippedDate,
                ShipPostalCode = order.ShipPostalCode,
                ShipRegion = order.ShipRegion,
                ShipVia = order.ShipVia
            };
        }

        //public virtual Customer Customer { get; set; }

        //public virtual Employee Employee { get; set; }

        //public virtual ICollection<Order_Detail> Order_Details { get; set; }

        //public virtual Shipper Shipper { get; set; }
    }
}