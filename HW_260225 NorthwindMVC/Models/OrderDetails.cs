using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_260225_NorthwindMVC.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}