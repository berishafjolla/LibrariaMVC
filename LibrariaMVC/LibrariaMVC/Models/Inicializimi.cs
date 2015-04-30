using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibrariaMVC.Models
{
    public class Inicializimi : DropCreateDatabaseIfModelChanges<LibrariaKontext>
    {
        protected override void Seed(LibrariaKontext context)
        {
            var genres = new List<Zhanri>
            {
                new Zhanri { Name = "Drame" },
                new Zhanri { Name = "Komedi" },
                new Zhanri { Name = "Tragjedi" },
                new Zhanri { Name = "Roman" },
                new Zhanri { Name = "Novele" },
                new Zhanri { Name = "Poezi" },
                new Zhanri { Name = "Histori" },
                new Zhanri { Name = "Proze" }
                
            };

            var letersia = new List<Letersia>
            {
                new Letersia { Emri = "Shqipe" },
                new Letersia { Emri = "Boterore" }
                
                
            };

            var artists = new List<Autori>
            {
                new Autori { Name = "Naim Frasheri" },
                new Autori { Name = "Ismail Kadare" },
                new Autori { Name = "Dritero Agolli" },
                new Autori { Name = "Faik Konica" },
                new Autori { Name = "Azem Shkreli" },
                new Autori { Name = "Ali Podrimja" },
                new Autori { Name = "Rexhep Qosja" },
                new Autori { Name = "Jeronim De Rada" },   
                new Autori { Name = "Ernest Koliqi" },
                new Autori { Name = "Kim Mehmeti" },
                new Autori { Name = "Sabri Hamiti" },
                new Autori { Name = "Mitrush Kuteli" },
                new Autori { Name = "Ndre Mjeda" },
                new Autori { Name = "Pashko Vasa" },
                new Autori { Name = "Sterjo Spase" },
                new Autori { Name = "Uiliam Shekspir" },
                new Autori { Name = "Molieri" },
                new Autori { Name = "Zhan Rasini" },
                new Autori { Name = "Viktor Hygo" },
                new Autori { Name = "Leo Tolstoi" },
                new Autori { Name = "Fiodor Dostojevski" },
                new Autori { Name = "Sami Frasheri" }

            };


            new List<Libri>
            {
                new Libri { Title = "Bageti e bujqesi", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Naim Frasheri"), Letersia = letersia.Single(g => g.Emri == "Shqipe"),AlbumArtUrl = "/Content/Images/naim.jpg" },
                new Libri { Title = "Lulet e veres", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Naim Frasheri"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/naim.jpg" },
                new Libri { Title = "Lissus", Zhanri = genres.Single(g => g.Name == "Proze"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Ndre Mjeda"), Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/ndre.jpg" },
                new Libri { Title = "Scodra", Zhanri = genres.Single(g => g.Name == "Proze"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Ndre Mjeda"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/ndre.jpg" },
                new Libri { Title = "Shqipëria ç´ka qenë, ç´është e ç´do të bëhet", Zhanri = genres.Single(g => g.Name == "Histori"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Sami Frasheri"),Letersia = letersia.Single(g => g.Emri == "Shqipe"),AlbumArtUrl = "/Content/Images/sami.JPG" },
               new Libri { Title = "Serafina Topia", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Jeronim De Rada"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/jeronim.jpg" },
                new Libri { Title = "Milosao", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Jeronim De Rada"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/jeronim.jpg" },
                new Libri { Title = "Historia e letërsisë shqipe III", Zhanri = genres.Single(g => g.Name == "Histori"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Rexhep Qosja"), Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/rexhep.jpg" },
            new Libri { Title = "Kushtrimi i Skanderbeut", Zhanri = genres.Single(g => g.Name == "Proze"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Ernest Koliqi"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/ernest.jpg" },
                new Libri { Title = "Keshtu Ecen Njeriu", Zhanri = genres.Single(g => g.Name == "Proze"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Kim Mehmeti"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/kim.jpg" },
                new Libri { Title = "Hamlet", Zhanri = genres.Single(g => g.Name == "Tragjedi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Uiliam Shekspir"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/shekspir.jpg" },
            new Libri { Title = "Romeo & Juliet", Zhanri = genres.Single(g => g.Name == "Tragjedi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Uiliam Shekspir"), Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/shekspir.jpg" },
                new Libri { Title = "Winter's Tale", Zhanri = genres.Single(g => g.Name == "Komedi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Uiliam Shekspir"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/shekspir.jpg" },
                new Libri { Title = "Andromaka", Zhanri = genres.Single(g => g.Name == "Komedi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Zhan Rasini"), Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/andromaka.jpg" },
                new Libri { Title = "Fedra", Zhanri = genres.Single(g => g.Name == "Komedi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Zhan Rasini"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/fedra.jpg" },
            new Libri { Title = "Tartuffe", Zhanri = genres.Single(g => g.Name == "Komedi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Molieri"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/molier.jpg" },
                new Libri { Title = "Les Misérables", Zhanri = genres.Single(g => g.Name == "Novele"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Viktor Hygo"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/viktor.jpg" },
                new Libri { Title = "Toilers of the Sea", Zhanri = genres.Single(g => g.Name == "Novele"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Viktor Hygo"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/viktor.jpg" },
                new Libri { Title = "Gjenerali i ushtrise se vdekur", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Ismail Kadare"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/ismail.jpg" },
            
                new Libri { Title = "Kështjella", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Ismail Kadare"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/ismail.jpg" },
                new Libri { Title = "Makbeth", Zhanri = genres.Single(g => g.Name == "Drame"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Uiliam Shekspir"), Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/shekspir.jpg" },
                new Libri { Title = "Rrjedhin lumenjtë", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Mitrush Kuteli"), Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/mitrush.jpg" },
                new Libri { Title = "Rose e spine", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Pashko Vasa"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/pashko.png" },
            new Libri { Title = "Pse", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Sterjo Spase"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/sterjo.jpg" },
                new Libri { Title = "Në rrugë dolla", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Dritero Agolli"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/dritero.jpg" },

                new Libri { Title = "Misioni", Zhanri = genres.Single(g => g.Name == "Drame"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Sabri Hamiti"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/sabri.jpg" },
                new Libri { Title = "Dr. Gjilpëra", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Faik Konica"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/faik.jpg" },
                new Libri { Title = "Karvani i bardhë", Zhanri = genres.Single(g => g.Name == "Proze"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Azem Shkreli"),Letersia = letersia.Single(g => g.Emri == "Shqipe"), AlbumArtUrl = "/Content/Images/azem.jpg" },
                new Libri { Title = "Lum Lumi", Zhanri = genres.Single(g => g.Name == "Poezi"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Ali Podrimja"),Letersia = letersia.Single(g => g.Emri == "Shqipe"),AlbumArtUrl = "/Content/Images/ali.jpg" },
                new Libri { Title = "Othelo", Zhanri = genres.Single(g => g.Name == "Drame"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Uiliam Shekspir"), Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/shekspir.jpg" },
            new Libri { Title = " Anna Karenina ", Zhanri = genres.Single(g => g.Name == "Novele"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Leo Tolstoi"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/ana.jpg" },
            new Libri { Title = "War and peace", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Leo Tolstoi"), Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/leo.jpg" },
            new Libri { Title = "Resurrection", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Leo Tolstoi"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/leo.jpg" },
            new Libri { Title = "The Idiot", Zhanri = genres.Single(g => g.Name == "Roman"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Fiodor Dostojevski"),Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/idiot.jpg" },
            new Libri { Title = "Demons", Zhanri = genres.Single(g => g.Name == "Novele"), Price = 8.99M, Autori = artists.Single(a => a.Name == "Fiodor Dostojevski"), Letersia = letersia.Single(g => g.Emri == "Boterore"), AlbumArtUrl = "/Content/Images/demons.jpg" },
            }.ForEach(a => context.tbl_Librat.Add(a));
            
        }
    }
}