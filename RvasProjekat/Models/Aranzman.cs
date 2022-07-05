using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Foolproof;

namespace RvasProjekat.Models
{
    public class Aranzman
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Drzava je neophodan!")]
        [Display(Name = "Destinacija aranzmana")]
        public string drzava { get; set; }

        [Required(ErrorMessage = "Grad je neophodan!")]
        [Display(Name = "Grad aranzmana")]
        public string grad { get; set; }

        [Required(ErrorMessage = "Cena je neophodna!")]
        [Display(Name = "Cena")]
        public decimal cena { get; set; }

        [Required(ErrorMessage = "Opis je neophodna!")]
        [Display(Name = "Opis")]
        public string opis { get; set; }

        [Required(ErrorMessage = "Slika je neophodna!")]
        [Display(Name = "Slika")]
        public string slika { get; set; }

        [Required(ErrorMessage = "Tip aranzmana je neophodan!")]
        [Display(Name = "Tip aranzmana")]
        public int AranzmanTipId { get; set; }

        public AranzmanTip AranzmanTip { get; set; }
    }
}