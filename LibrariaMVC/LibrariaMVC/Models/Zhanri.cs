using System.Collections.Generic;

namespace LibrariaMVC.Models
{
    public partial class Zhanri
    {
        public int ZhanriId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Libri> tbl_Librat { get; set; }
    }
}
