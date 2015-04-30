using System.ComponentModel.DataAnnotations;

namespace LibrariaMVC.Models
{
    public class Shporta
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int LibriId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Libri Libri { get; set; }
    }
}