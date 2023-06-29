using CoreAracKiralama.Data;
using CoreAracKiralama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreAracKiralama.Controllers
{
    public class AraclarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AraclarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Araclar.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Araclar kaydet)
        {
            _db.Add(kaydet);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var araclar = _db.Araclar.Find(id);
            return View(araclar);
        }
        [HttpPost]
        public IActionResult Edit(int id, Araclar yenile)
        {
            _db.Update(yenile);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var araclar = _db.Araclar.Find(id);
            _db.Araclar.Remove(araclar);
            return RedirectToAction("Index");
        }

    }
}
