using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_260225_NorthwindMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCountry { get; set; }
    }
}