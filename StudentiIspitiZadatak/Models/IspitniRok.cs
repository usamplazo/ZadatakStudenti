using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentiIspitiZadatak.Models;

namespace StudentiIspitiZadatak.Models
{
    [Table("IspitniRokovi")]
    public class IspitniRok
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Oznaka Roka")]
        [Required(ErrorMessage = "Morate uneti Oznaku roka")]
        public string OznakaRoka { get; set; }

        [Required(ErrorMessage = "Morate uneti Godinu Roka")]
        [Display(Name = "Godina Roka")]
        public int GodinaRoka { get; set; }

        [Required(ErrorMessage = "Morate uneti Naziv Roka")]
        [StringLength(25)]
        [Display(Name = "Naziv Roka")]
        public string Naziv { get; set; }
        public ICollection<Ispit> Ispit { get; set; }
    }
}