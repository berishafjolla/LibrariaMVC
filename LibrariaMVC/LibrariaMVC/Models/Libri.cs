using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace LibrariaMVC.Models
{
    [Bind(Exclude = "LibriId")]
    public class Libri
    {
        [ScaffoldColumn(false)]
        public int LibriId { get; set; }

        [DisplayName("Zhanri")]
        public int ZhanriId { get; set; }

        [DisplayName("Letersia")]
        public int LetersiaId { get; set; }

        [DisplayName("Autori")]
        public int AutoriId { get; set; }

        [Required(ErrorMessage = "Titulli kerkohet")]
        [StringLength(160)]
        public string Title { get; set; }

        

        [Required(ErrorMessage = "Cmimi kerkohet")]
        [Range(5, 100,
            ErrorMessage = "Cmimi mes 5 dhe 100")]
        public decimal Price { get; set; }

        [DisplayName("Libri Art URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Zhanri Zhanri { get; set; }
        public virtual Autori Autori { get; set; }
        public virtual Letersia Letersia { get; set; }
        public virtual List<PorosiaDetaj> tbl_PorosiaDetajuar { get; set; }
    }
}