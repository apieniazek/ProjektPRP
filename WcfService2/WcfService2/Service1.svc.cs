using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void dodajGatunek(Gatunek g)
        {
            Gry_model gm = new Gry_model();
            gm.Gatunek.Add(g);
            gm.SaveChanges();
        }

        public void dodajGre(Gry g)
        {
            Gry_model gm = new Gry_model();
            gm.Gry.Add(g);
            try
            {
                gm.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine(@"Entity of type ""{0}"" in state ""{1}"" 
                   has the following validation errors:",
                        eve.Entry.Entity.GetType().Name,
                        eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine(@"- Property: ""{0}"", Error: ""{1}""",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (DbUpdateException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void dodajOcene(Oceny o)
        {
            Gry_model gm = new Gry_model();
            gm.Oceny.Add(o);
            gm.SaveChanges();
        }

        public void dodajProducenta(Producent p)
        {
            Gry_model gm = new Gry_model();
            gm.Producent.Add(p);
            gm.SaveChanges();
            

        }

        public void edytujGatunek(Gatunek g)
        {
            Gry_model gm = new Gry_model();
            var query = (from ga in gm.Gatunek
                         where ga.Id_gatunek == g.Id_gatunek
                         select ga).First();
            query.Nazwa = g.Nazwa;
            gm.SaveChanges();
        }

        public void edytujGre(Gry g)
        {
            Gry_model gm = new Gry_model();
            var query = (from gr in gm.Gry
                         where gr.Id == g.Id
                         select gr).First();
            query.Tytul = g.Tytul;
            query.Producent_Id = g.Producent_Id;
            query.Gatunek_Id = g.Gatunek_Id;
            query.Rok_wydania = g.Rok_wydania;
            query.Kraj = g.Kraj;
            query.Platforma = g.Platforma;
            query.Ocena_Id = g.Ocena_Id;
            query.link_okladka = g.link_okladka;
            query.opis = g.opis;
            gm.SaveChanges();
        }

        public void edytujOcene(Oceny o)
        {
            Gry_model gm = new Gry_model();
            var query = (from oc in gm.Oceny
                         where oc.Id_oceny == o.Id_oceny
                         select oc).First();
            query.Gry_online_pl = o.Gry_online_pl;
            query.Eurogamer = o.Eurogamer;
            query.Moja_ocena = o.Moja_ocena;
            query.Srednia_ocena = o.Srednia_ocena;
            gm.SaveChanges();
        }

        public void edytujProducenta(Producent p)
        {
            Gry_model gm = new Gry_model();
            var query = (from pr in gm.Producent
                         where pr.Id_producent == p.Id_producent
                         select pr).First();
            query.Nazwa = p.Nazwa;
            query.Zalozyciel = p.Zalozyciel;
            query.Rok_zalozenia = p.Rok_zalozenia;
            gm.SaveChanges();
        }

        public int pobierzOcenaId()
        {
            Gry_model gm = new Gry_model();
            return gm.Oceny.Max(id => id.Id_oceny);
        }

        public void ustawPlatforme(List<GryProdGatOc> lst)
        {
            foreach (var item in lst)
            {
                if (item.platforma == 1)
                    item.platformas = "PC";
                else
                if (item.platforma == 2)
                    item.platformas = "PS4";
                else
                if (item.platforma == 3)
                    item.platformas = "PC, PS4";
                else
                if (item.platforma == 4)
                    item.platformas = "XBOX";
                else
                if (item.platforma == 5)
                    item.platformas = "PC, XBOX";
                else
                if (item.platforma == 6)
                    item.platformas = "PS4, XBOX";
                else
                if (item.platforma == 7)
                    item.platformas = "PC, PS4, XBOX";

            }
        }

        public void usunGatunek(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from ga in gm.Gatunek
                         where ga.Id_gatunek == id
                         select ga).First();
            gm.Gatunek.Remove(query);
            gm.SaveChanges();
        }

        public void usunGre(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from gr in gm.Gry
                         where gr.Id == id
                         select gr).First();
            gm.Gry.Remove(query);
            gm.SaveChanges();
        }

        public void usunOcene(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from oc in gm.Oceny
                         where oc.Id_oceny == id
                         select oc).First();
            gm.Oceny.Remove(query);
            gm.SaveChanges();
        }

        public void usunProducenta(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from pr in gm.Producent
                         where pr.Id_producent == id
                         select pr).First();
            gm.Producent.Remove(query);
            gm.SaveChanges();

        }

        public List<Gatunek> wyswietlGatunek(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from gt in gm.Gatunek
                         where gt.Id_gatunek == id
                         select gt).ToList();
            return query;
        }

        public List<Gatunek> wyswietlGatunki()
        {
            Gry_model gm = new Gry_model();
            return gm.Gatunek.ToList();
        }

        public List<GryProdGatOc> wyswietlGre(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Id == id
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             platformas = "",
                             link_okladka = gr.link_okladka,
                             opis = gr.opis,
                             gry_online_pl = oc.Gry_online_pl,
                             eurogamer_com = oc.Eurogamer,
                             id_oceny = gr.Ocena_Id,
                             id_gatunek = gr.Gatunek_Id,
                             id_producent = gr.Producent_Id

                         }).ToList();
            ustawPlatforme(query);

            return query;
        }

        public List<GryProdGatOc> wyswietlGry(int i, string tytul, int p, int g)
        {
            Gry_model gm = new Gry_model();
            List<GryProdGatOc> query = new List<GryProdGatOc>();
            if(i == 0)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             eurogamer_com = oc.Eurogamer,
                             gry_online_pl = oc.Gry_online_pl,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if(i == 1)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Tytul.Contains(tytul) 
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if (i == 2)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Producent_Id == p
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if (i == 3)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Tytul.Contains(tytul) & gr.Producent_Id == p
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if (i == 4)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Gatunek_Id == g
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if (i == 5)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Tytul.Contains(tytul) & gr.Gatunek_Id == g
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if (i == 6)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Producent_Id == p & gr.Gatunek_Id == g
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }
            if (i == 7)
            {
                query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         where gr.Tytul.Contains(tytul) & gr.Producent_Id == p & gr.Gatunek_Id == g
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena,
                             Srednia_ocena = oc.Srednia_ocena,
                             platformas = ""
                         }).ToList();
            }

            ustawPlatforme(query);
            return query;
        }

        public List<Producent> wyswietlProducent(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from pr in gm.Producent
                         where pr.Id_producent == id
                         select pr).ToList();
            return query;
        }

        public List<Producent> wyswietlProducentow()
        {
            Gry_model gm = new Gry_model();
            return gm.Producent.ToList();
        }

        public double sredniaocena(double a, double b, double c)
        {
            double result;
            result = ((a+b+c)/3);
            return result;
        }
   
    }
}
