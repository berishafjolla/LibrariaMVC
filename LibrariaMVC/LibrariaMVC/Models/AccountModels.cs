using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;


namespace Mvc3ToolsUpdateWeb_Default.Models
{

   

    public class LogOnModel
    {
        [Required]
        [Display(Name = "Shfrytezuesi")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Fjalekalimi")]
        public string Password { get; set; }

        [Display(Name = "Me mbani ne mend?")]
        public bool RememberMe { get; set; }
    }

   
}
