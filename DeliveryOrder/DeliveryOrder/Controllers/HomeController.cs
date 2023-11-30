using DeliveryOrder.Database;
using DeliveryOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DeliveryOrder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Delivery> deliveres = _db.Deliveries;

            return View(deliveres);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _db.Deliveries.Add(delivery);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var delivery = _db.Deliveries.Find(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);

            //var delivery = _db.Deliveries.FirstOrDefault(d => d.Id == id);

            //if (delivery == null)
            //{
            //    return NotFound();
            //}

            //return View(delivery);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}