using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using LibrariaMVC.Models;

namespace LibrariaMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        LibrariaKontext storeDB = new LibrariaKontext();

        public ActionResult Index()
        {
            
            var librat = LibratPelqyer(5);

            return View(librat);
        }

        private List<Libri> LibratPelqyer(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return storeDB.tbl_Librat
                .OrderByDescending(a => a.tbl_PorosiaDetajuar.Count())
                .Take(count)
                .ToList();
        }

        public ActionResult Search(string q)
        {
            var librat = storeDB.tbl_Librat
            .Include("Autori")
            .Where(a => a.Title.Contains(q))
            .Take(10);
            return View(librat);
        }
    }
}