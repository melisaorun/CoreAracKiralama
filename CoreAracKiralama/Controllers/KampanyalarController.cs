using CoreAracKiralama.Data;
using CoreAracKiralama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreAracKiralama.Controllers
{
    public class KampanyalarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KampanyalarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Kampanyalar.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Kampanyalar kaydet)
        {
            _db.Add(kaydet);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var kampanyalar = _db.Kampanyalar.Find(id);
            return View(kampanyalar);
        }
        [HttpPost]
        public IActionResult Edit(int id, Kampanyalar yenile)
        {
            _db.Update(yenile);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var kampanyalar = _db.Kampanyalar.Find(id);
            _db.Kampanyalar.Remove(kampanyalar);
            return RedirectToAction("Index");
        }

    }
}
