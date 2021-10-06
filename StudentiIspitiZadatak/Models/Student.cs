using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentiIspitiZadatak.Models;
namespace StudentiIspitiZadatak.Models
{
    [Table("Studenti")]
    public class Student
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Broj Indexa")]
        [Required(ErrorMessage ="Morate uneti Broj Indexa")]
        public int BrIndexa { get; set; }

        [Required(ErrorMessage ="Morate uneti Ime")]
        [StringLength(30, ErrorMessage ="Ime moze sadrzati najvise 30 karaktera")]
        public string Ime { get; set; }

        [Required(ErrorMessage ="Morate uneti Prezime")]
        [StringLength(30, ErrorMessage = "Prezime moze sadrzati najvise 30 karaktera")]
        public string Prezime { get; set; }

        [Required(ErrorMessage ="Morate uneti Datum Rodjenja")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Rodjenja")]
      
     
      
        public DateTime DatumRodjenja { get; set; }

        [Required(ErrorMessage = "Morate uneti Mesto Rodjenja")]
        [Display(Name = "Mesto Rodjenja")]
        public string MestoRodjenja { get; set; }

        [Required(ErrorMessage = "Morate uneti Datum Upisa")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Upisa")]
      
    
        public DateTime DatumUpisa { get; set; }
        public ICollection<Ispit> Ispit { get; set; }
    }
}