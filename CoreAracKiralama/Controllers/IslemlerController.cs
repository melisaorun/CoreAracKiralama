using CoreAracKiralama.Data;
using CoreAracKiralama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreAracKiralama.Controllers
{
    public class IslemlerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IslemlerController(ApplicationDbContext db) 
        { 
            _db = db;
        }
        public IActionResult Index()
        {
            var listele= _db.Islemler.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Islemler kaydet)
        {
            _db.Add(kaydet);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var ıslemler=_db.Islemler.Find(id);
            return View(ıslemler);
        }
        [HttpPost]
        public IActionResult Edit(int id,Islemler yenile)
        {
            _db.Update(yenile);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var ıslemler = _db.Islemler.Find(id);
            _db.Islemler.Remove(ıslemler);
            return RedirectToAction("Index");
        }
       
    }
}
