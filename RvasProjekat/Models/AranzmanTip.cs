using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace RvasProjekat.Models
{
    public class AranzmanTip
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Pansion aranzmana je neophodan!")]
        [Display(Name = "Pansion aranzmana")]
        public string pansion   { get; set; }
        [Required(ErrorMessage = "Tip aranzmana je neophodan!")]
        [Display(Name = "Tip aranzmana")]
        public string tip { get; set; }


    }
}