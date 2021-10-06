using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentiIspitiZadatak.Models;
namespace StudentiIspitiZadatak.Models
{
    [Table("Ispiti")]
    public class Ispit
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Morate uneti Datum Roka")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Roka")]
        public DateTime DatumRoka { get; set; }

        [Required(ErrorMessage = "Morate uneti Bodove Roka")]
        [Display(Name = "Bodovi Roka")]
        public float BodoviRoka { get; set; }


        [ForeignKey("IspitniRokID")]
        public IspitniRok IspitniRok { get; set; }
        public string IspitniRokID { get; set; }

        [ForeignKey("StudentID")]
        public Student Student { get; set; }
        public int StudentID { get; set; }

        [ForeignKey("PredmetID")]
        public Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
    }
}