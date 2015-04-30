namespace LibrariaMVC.Models
{
    public class PorosiaDetaj
    {
        public int PorosiaDetajId { get; set; }
        public int PorosiaId { get; set; }
        public int LibriId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Libri Libri { get; set; }
        public virtual Porosia Porosia { get; set; }
    }
}
