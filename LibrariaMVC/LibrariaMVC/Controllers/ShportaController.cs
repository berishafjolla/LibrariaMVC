using System.Linq;
using System.Web.Mvc;
using LibrariaMVC.Models;
using LibrariaMVC.ViewModels;

namespace LibrariaMVC.Controllers
{
    public class ShportaController : Controller
    {
        LibrariaKontext storeDB = new LibrariaKontext();

        //
        // GET: /Shporta/

        public ActionResult Index()
        {
            var cart = Blerja.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }

        //
        // GET: /Libraria/AddToCart/5

        public ActionResult AddToCart(int id)
        {

            // Retrieve the album from the database
            var addedAlbum = storeDB.tbl_Librat
                .Single(album => album.LibriId == id);

            // Add it to the shopping cart
            var cart = Blerja.GetCart(this.HttpContext);

            cart.AddToCart(addedAlbum);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /Shporta/RemoveFromCart/5

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = Blerja.GetCart(this.HttpContext);

            // Get the name of the album to display confirmation
            string albumName = storeDB.tbl_Shporta
                .Single(item => item.RecordId == id).Libri.Title;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(albumName) +
                    " eshte larguar nga shporta juaj.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeletedId = id
            };

            return Json(results);
        }

        //
        // GET: /Shporta/Permbledhje

        [ChildActionOnly]
        public ActionResult Permbledhje()
        {
            var cart = Blerja.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();

            return PartialView("Permbledhje");
        }
    }
}