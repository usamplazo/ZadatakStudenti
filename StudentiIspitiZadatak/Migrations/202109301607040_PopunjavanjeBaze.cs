namespace StudentiIspitiZadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopunjavanjeBaze : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Studenti(BrIndexa, Ime, Prezime, DatumRodjenja, MestoRodjenja, DatumUpisa) VALUES (25320, 'Mirko', 'Mirkovic', '19781225', 'Beograd', '20200110')");
            Sql("INSERT INTO Studenti(BrIndexa, Ime, Prezime, DatumRodjenja, MestoRodjenja, DatumUpisa) VALUES (10520, 'Luka', 'Lukic', '19680217', 'Novi Sad', '20200710')");
            Sql("INSERT INTO Studenti(BrIndexa, Ime, Prezime, DatumRodjenja, MestoRodjenja, DatumUpisa) VALUES (25520, 'Zeljko', 'Zeljkovic', '19630510', 'Trsic', '20200106')");
            Sql("INSERT INTO Studenti(BrIndexa, Ime, Prezime, DatumRodjenja, MestoRodjenja, DatumUpisa) VALUES (38620, 'Petar', 'Petrovic', '19770430', 'Podgorica', '20200305')");
            Sql("INSERT INTO Studenti(BrIndexa, Ime, Prezime, DatumRodjenja, MestoRodjenja, DatumUpisa) VALUES (45520, 'Nadezda', 'Petrovic', '19781225', 'Beograd', '20200110')");

            Sql("INSERT INTO Predmeti(Sifra, Naziv, ESBPBodovi) VALUES(1122, 'Engleski jezik', 8)");
            Sql("INSERT INTO Predmeti(Sifra, Naziv, ESBPBodovi) VALUES(1222, 'Uvod u MATLAB', 7)");
            Sql("INSERT INTO Predmeti(Sifra, Naziv, ESBPBodovi) VALUES(2321, 'Programerski alati', 9)");
            Sql("INSERT INTO Predmeti(Sifra, Naziv, ESBPBodovi) VALUES(5685, 'OOP', 10)");

            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('3abc2', 2021, 'Januarski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('2rbs2', 2021, 'Martovski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('4bvw7', 2021, 'Aprilski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('0dfs1', 2021, 'Majski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('5qds1', 2021, 'Junski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('9sdx6', 2021, 'Julski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('6ht6y', 2021, 'Septembarksi')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('5ff36', 2021, 'Oktobarski')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('6asd8', 2021, 'Oktobar 2')");
            Sql("INSERT INTO IspitniRokovi(OznakaRoka, GodinaRoka, Naziv) VALUES('8dfe8', 2021, 'Decembarski')");

            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210110', 80, '3abc2', 25320, 1122)");
            //isti rok drugi predmet
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210110', 90, '3abc2', 25320, 2321)");
            //drugi rok isti predmet (oboren)
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211010' , 100, '6asd8', 25320, 1122)");
            //drugi student isti predmet isti rok
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210110', 95, '3abc2', 10520, 1122)");
            //drugi student isti predmet drugi rok
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210920', 99, '6ht6y', 10520, 1122)");
            //drugi student drugi predmet drugi rok
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210415', 75, '4bvw7', 10520, 5685)");

            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211215', 65, '8dfe8', 25520, 2321)");
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211215' , 88, '8dfe8', 25520, 1222)");
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211215', 65, '8dfe8', 25520, 2321)");

            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210701' , 65, '9sdx6', 38620, 5685)");
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20210701', 91, '9sdx6', 38620, 1122)");

            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211001', 91, '9sdx6', 45520, 1122)");
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211001' , 72, '9sdx6', 45520, 1222)");
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211001' , 55, '9sdx6', 45520, 5685)");
            Sql("INSERT INTO Ispiti(DatumRoka, BodoviRoka, IspitniRokID, StudentID, PredmetID) VALUES('20211001' , 98, '9sdx6', 45520, 2321)");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Studenti");
            Sql("DELETE FROM Predmeti");
            Sql("DELETE FROM IspitniRokovi");
            Sql("DELETE FROM Predmeti");
        }
    }
    }

