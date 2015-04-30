using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrariaMVC.Models
{
    public class Letersia
    {
        public int LetersiaId { get; set; }
        public string Emri { get; set; }
        
        public List<Libri> tbl_Librat { get; set; }
    }
}