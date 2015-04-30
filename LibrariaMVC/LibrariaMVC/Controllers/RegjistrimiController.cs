using System;
using System.Linq;
using System.Web.Mvc;
using LibrariaMVC.Models;

namespace LibrariaMVC.Controllers
{
    
    public class RegjistrimiController : Controller
    {
        LibrariaKontext storeDB = new LibrariaKontext();
       

        //
        // GET: /Regjistrimi/Adresa

        public ActionResult Adresa()
        {
            return View();
        }

        //
        // POST: /Regjistrimi/Adresa

        [HttpPost]
        public ActionResult Adresa(FormCollection values)
        {
            var order = new Porosia();
            TryUpdateModel(order);

            try
            {
               
                    order.Username = User.Identity.Name;
                    order.OrderDate = DateTime.Now;

                    //Save Porosia
                    storeDB.tbl_Porosia.Add(order);
                    storeDB.SaveChanges();

                    //Process the order
                    var cart = Blerja.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.PorosiaId });
                }

            
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        //
        // GET: /Regjistrimi/Complete

        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = storeDB.tbl_Porosia.Any(
                o => o.PorosiaId == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
