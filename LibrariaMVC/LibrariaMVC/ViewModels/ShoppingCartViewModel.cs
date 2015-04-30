using System.Collections.Generic;
using LibrariaMVC.Models;

namespace LibrariaMVC.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Shporta> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}