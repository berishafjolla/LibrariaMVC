using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LibrariaMVC.Models
{
    [Bind(Exclude = "PorosiaId")]
    public partial class Porosia
    {
        [ScaffoldColumn(false)]
        public int PorosiaId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Emri kerkohet")]
        [DisplayName("Emri")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Mbiemri kerkohet")]
        [DisplayName("Mbiemri")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adresa kerkohet")]
        [DisplayName("Adresa")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Qyteti kerkohet")]
        [DisplayName("Qyteti")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Shteti kerkohet")]
        [DisplayName("Shteti")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Kodi postal kerkohet")]
        [DisplayName("Kodi postal")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        
        [Required(ErrorMessage = "Numri i telefonit kerkohet")]
        [DisplayName("Numri i tel.")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email adresa kerkohet")]
        [DisplayName("Email Adresa")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email nuk eshte i vlefshem.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<PorosiaDetaj> tbl_PorosiaDetajuar { get; set; }
    }
}
