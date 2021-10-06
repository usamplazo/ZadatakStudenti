using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentiIspitiZadatak.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentiIspitiZadatak.ViewModels
{
    public class IspitiViewModel
    {
        [Required(ErrorMessage = "Morate uneti Datum Roka")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Roka")]
        public DateTime DatumRoka { get; set; }

        [Required(ErrorMessage = "Morate uneti Bodove Roka")]
        [Display(Name = "Bodovi Roka")]
        public float BodoviRoka { get; set; }
        public IEnumerable<Ispit> Ispiti { get; set; }
        public Predmet Predmet { get; set; }
        public IspitniRok IspitniRok { get; set; }
        public Student Student { get; set; }

        


    }
}