using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using StudentiIspitiZadatak.Models;

namespace StudentiIspitiZadatak.ViewModels
{
    public class IspitIzmenaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Morate uneti Datum Roka")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Roka")]
        public DateTime DatumRoka { get; set; }

        [Required(ErrorMessage = "Morate uneti Bodove Roka")]
        [Display(Name = "Bodovi Roka")]
        public float BodoviRoka { get; set; }

        public string IspitniRokID { get; set; }

        public int StudentID { get; set; }

        public int PredmetID { get; set; }
        public IEnumerable<Predmet> PredmetiDL { get; set; }
        public IEnumerable<IspitniRok> IspitniRokoviDL { get; set; }
        public IEnumerable<Student> StudentiDL { get; set; }
    }
}