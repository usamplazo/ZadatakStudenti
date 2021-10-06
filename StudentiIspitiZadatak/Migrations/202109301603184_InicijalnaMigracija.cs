namespace StudentiIspitiZadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicijalnaMigracija : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ispiti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumRoka = c.DateTime(nullable: false),
                        BodoviRoka = c.Single(nullable: false),
                        IspitniRokID = c.String(maxLength: 128),
                        StudentID = c.Int(nullable: false),
                        PredmetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IspitniRokovi", t => t.IspitniRokID)
                .ForeignKey("dbo.Predmeti", t => t.PredmetID, cascadeDelete: true)
                .ForeignKey("dbo.Studenti", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.IspitniRokID)
                .Index(t => t.StudentID)
                .Index(t => t.PredmetID);
            
            CreateTable(
                "dbo.IspitniRokovi",
                c => new
                    {
                        OznakaRoka = c.String(nullable: false, maxLength: 128),
                        GodinaRoka = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.OznakaRoka);
            
            CreateTable(
                "dbo.Predmeti",
                c => new
                    {
                        Sifra = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 20),
                        ESBPBodovi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sifra);
            
            CreateTable(
                "dbo.Studenti",
                c => new
                    {
                        BrIndexa = c.Int(nullable: false),
                        Ime = c.String(nullable: false, maxLength: 30),
                        Prezime = c.String(nullable: false, maxLength: 30),
                        DatumRodjenja = c.DateTime(nullable: false),
                        MestoRodjenja = c.String(nullable: false),
                        DatumUpisa = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BrIndexa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ispiti", "StudentID", "dbo.Studenti");
            DropForeignKey("dbo.Ispiti", "PredmetID", "dbo.Predmeti");
            DropForeignKey("dbo.Ispiti", "IspitniRokID", "dbo.IspitniRokovi");
            DropIndex("dbo.Ispiti", new[] { "PredmetID" });
            DropIndex("dbo.Ispiti", new[] { "StudentID" });
            DropIndex("dbo.Ispiti", new[] { "IspitniRokID" });
            DropTable("dbo.Studenti");
            DropTable("dbo.Predmeti");
            DropTable("dbo.IspitniRokovi");
            DropTable("dbo.Ispiti");
        }
    }
}
