using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibrariaMVC.Models;

namespace LibrariaMVC.Controllers
{
    public class LibrariaController : Controller
    {
        LibrariaKontext storeDB = new LibrariaKontext();

        //
        // GET: /Libraria/

        public ActionResult Index()
        {
            var librat = storeDB.tbl_Librat.OrderBy(o => o.Autori.Name);
            return View(librat);
        }
        
        //
        // GET: /Libraria/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            // Retrieve Zhanri and its Associated tbl_Librat from database
            var genreModel = storeDB.tbl_Zhanret.Include("tbl_Librat")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        //
        // GET: /Libraria/Details/5

        public ActionResult Details(int id)
        {
            var album = storeDB.tbl_Librat.Find(id);

            return View(album);
        }

        public ActionResult Browse_Letersia(string letersia)
        {
            
            var llojiLetersia = storeDB.tbl_Letersia.Include("tbl_Librat")
                .Single(g => g.Emri == letersia);

            return View(llojiLetersia);
        }
        //
        // GET: /Libraria/ZhanreMeny

        [ChildActionOnly]
        public ActionResult ZhanreMeny()
        {
            var genres = storeDB.tbl_Zhanret.ToList();

            return PartialView(genres);
        }

        [ChildActionOnly]
        public ActionResult Letersia()
        {
            var letersia = storeDB.tbl_Letersia.ToList();

            return PartialView(letersia);
        }
       
    }
}