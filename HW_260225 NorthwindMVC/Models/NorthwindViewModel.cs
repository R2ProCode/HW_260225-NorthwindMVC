using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_260225_NorthwindMVC.Models
{
    public class NorthwindViewModel
    {
        public List<Order> Orders { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public DateTime TodaysDate { get; set; }
    } 
}