using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibrariaMVC.Models;

namespace LibrariaMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private LibrariaKontext db = new LibrariaKontext();

        //
        // GET: /Admin/

        public ViewResult Index()
        {
            var albums = db.tbl_Librat.Include(a => a.Zhanri).Include(a => a.Autori);
            return View(albums.ToList());
        }

        //
        // GET: /Admin/Details/5

        public ViewResult Details(int id)
        {
            Libri album = db.tbl_Librat.Find(id);
            return View(album);
        }

        //
        // GET: /Admin/Krijo

        public ActionResult Krijo()
        {
            ViewBag.ZhanriId = new SelectList(db.tbl_Zhanret, "ZhanriId", "Name");
            ViewBag.AutoriId = new SelectList(db.tbl_Autoret, "AutoriId", "Name");
            ViewBag.Letersiaid = new SelectList(db.tbl_Letersia, "LetersiaId", "Emri");
            return View();
        } 

        //
        // POST: /Admin/Krijo

        [HttpPost]
        public ActionResult Krijo(Libri album)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Librat.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ZhanriId = new SelectList(db.tbl_Zhanret, "ZhanriId", "Name", album.ZhanriId);
            ViewBag.AutoriId = new SelectList(db.tbl_Autoret, "AutoriId", "Name", album.AutoriId);
            ViewBag.Letersiaid = new SelectList(db.tbl_Letersia, "LetersiaId", "Emri",album.LetersiaId);
            return View(album);
        }
        
     
 
        public ActionResult Delete(int id)
        {
            Libri album = db.tbl_Librat.Find(id);
            return View(album);
        }

     

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Libri album = db.tbl_Librat.Find(id);
            db.tbl_Librat.Remove(album);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}