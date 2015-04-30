using System.Data.Entity;

namespace LibrariaMVC.Models
{
    public class LibrariaKontext : DbContext
    {
        public DbSet<Libri> tbl_Librat { get; set; }
        public DbSet<Letersia> tbl_Letersia { get; set; }
        public DbSet<Zhanri> tbl_Zhanret { get; set; }
        public DbSet<Autori> tbl_Autoret { get; set; }
        public DbSet<Shporta> tbl_Shporta { get; set; }
        public DbSet<Porosia> tbl_Porosia { get; set; }
        public DbSet<PorosiaDetaj> tbl_PorosiaDetajuar { get; set; }
    }
}