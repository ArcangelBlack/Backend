using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace DeliverBackend.Models
{
    public class Order : BaseModel
    {
        public int Number { get; set; }

        public string UserId { get; set; }

        public string AddressId { get; set; }

        public string TransporterId { get; set; }

        public bool IsOpen { get; set; }

        public double Price { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ClosedDate { get; set; }

        public int SendType { get; set; }
    }

    public class OrderDetail : BaseModel
    {
        public string OrderId { get; set; }

        public string ProductId { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }
    }
}