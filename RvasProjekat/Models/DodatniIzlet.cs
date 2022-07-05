using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RvasProjekat.Models
{
    public class DodatniIzlet
    {

        public int Id { get; set; }

        public string ime { get; set; }

        public string opis { get; set; }

        public float cena { get; set; }

        public int AranzmanId { get; set; }

        public Aranzman Aranzman { get; set; }

    }
}