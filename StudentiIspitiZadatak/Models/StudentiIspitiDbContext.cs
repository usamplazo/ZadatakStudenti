using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StudentiIspitiZadatak.Models;
namespace StudentiIspitiZadatak.Models
{
    public class StudentiIspitiDbContext : DbContext
    {
        public StudentiIspitiDbContext() : base("name=KonekcijaBP")
        {

        }

        public DbSet<Student> StudentDbSet { get; set; }
        public DbSet<Predmet> PredmetDbSet { get; set; }
        public DbSet<Ispit> IspitDbSet { get; set; }

        public DbSet<IspitniRok> IspitniRokDbSet { get; set; }

        public static StudentiIspitiDbContext Create()
        {
            return new StudentiIspitiDbContext();
        }

    }
}