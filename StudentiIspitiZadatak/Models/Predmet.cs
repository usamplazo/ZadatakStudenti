using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentiIspitiZadatak.Models;

namespace StudentiIspitiZadatak.Models
{
    [Table("Predmeti")]
    public class Predmet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sifra Predmeta")]
        public int Sifra { get; set; }

        [Required(ErrorMessage = "Morate uneti Naziv Predmeta")]
        [StringLength(20)]
        [Display(Name = "Naziv Predmeta")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Morate uneti ESBP Bodove")]
        [Display(Name = "ESBP Bodovi")]
        public int ESBPBodovi { get; set; }
        public ICollection<Ispit> Ispit { get; set; }
    }
}