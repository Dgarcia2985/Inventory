using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InventoryWeb.Models;

namespace InventoryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new InventoryViewModel();
            model.InventoryItems = model.GetItemInventory();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/{id:int}")]
        public IActionResult Details(int id)
        {
            var model = new InventoryViewModel();
            model.Details = model.GetDeatilbyItemId(id);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
