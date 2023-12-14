using CustomerProjectApp.Data.Migrations;
using CustomerProjectApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerProjectApp.Controllers
{
    public class ReservationController : Controller
    {
        private readonly YourDbContextModel _context;
        public ReservationController(YourDbContextModel context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var reservations = _context.Reservations.Include(r=>r.Table).Include(r=>r.User).ToList();
            return View(reservations);
        }
        public IActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reservation);
        }
    }
}
