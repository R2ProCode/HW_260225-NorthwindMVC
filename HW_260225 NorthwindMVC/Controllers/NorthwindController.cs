using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW_260225_NorthwindMVC.Models;
using HW_260225_NorthwindMVC.Properties;

namespace HW_260225_NorthwindMVC.Controllers
{
    public class NorthwindController : Controller
    {
        // GET: Northwind
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders()
        {
            NorthwindDbManager northwindDbManager = new NorthwindDbManager(Properties.Settings.Default.Constr);
            NorthwindViewModel viewModel = new NorthwindViewModel();
            viewModel.Orders = northwindDbManager.GetOrders();
            viewModel.TodaysDate = DateTime.Now;
            return View(viewModel);
        }

        public ActionResult OrderDetails()
        {
            NorthwindDbManager northwindDbManager = new NorthwindDbManager(Properties.Settings.Default.Constr);
            NorthwindViewModel viewModel = new NorthwindViewModel();
            viewModel.OrderDetails = northwindDbManager.GetOrderDetails();
            return View(viewModel);
        }
    }
}