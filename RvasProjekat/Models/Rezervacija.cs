using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Foolproof;

namespace RvasProjekat.Models
{
    public class Rezervacija
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "Datum ostajanja Od je neophodan!")]
        [Display(Name = "Datum od")]
        public DateTime DateOd { get; set; }


        [Required(ErrorMessage = "Datum ostajanja Do je neophodan!")]
        [GreaterThan("OstajanjeOd")]
        [Display(Name = "Datum do")]
        public DateTime DateDo { get; set; }

        [Required(ErrorMessage = "Aranzman je neophodna!")]
        [Display(Name = "Izaberite Aranzman")]
        public int AranzmanId { get; set; }

        [Required(ErrorMessage = "Korsnik je neophodan!")]
        [Display(Name = "Izaberite korisnika")]
        public string ApplicationUserId { get; set; }


        public Aranzman Aranzman  { get; set; }

        public ApplicationUser ApplicationUser { get; set; }




    }
}