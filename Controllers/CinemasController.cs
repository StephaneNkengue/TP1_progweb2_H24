using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        internal static readonly List<Cinema> Cinemas = new()
        {
            new () {CinemaId = 1, Nom="Guzzo", DateCreation = new DateTime(1974, 7, 9), NombreSalle = 14, Courriel  = "Guzzo@gmail.com", Telephone = "8198214481", Ville = "Sherbrooke"},
            new () { CinemaId = 2, Nom = "Cineplex", DateCreation = new DateTime(1999, 10, 4), NombreSalle=12, Courriel = "Cineplex@gmail.com", Telephone = "4507766908", Ville = "Granby"},
            new () { CinemaId = 3, Nom = "Cinema Princesse", DateCreation = new DateTime(1993, 3, 20), NombreSalle=4, Courriel = "CinemaPrincesse@gmail.com", Telephone = "4502635900", Ville = "Cowansville"},
            new () { CinemaId = 4, Nom = "Cinema Beaubien", DateCreation = new DateTime(2002, 11, 27), NombreSalle=8, Courriel = "CinemaBeaubien@gmail.com", Telephone = "5147216060", Ville = "Montreal"},
            new () { CinemaId = 5, Nom = "cinema RGFM", DateCreation = new DateTime(1976, 5, 10), NombreSalle=7, Courriel = "CinemaRGFN@gmail.com", Telephone = "8884546926", Ville = "Beloeil"},
            new () { CinemaId = 6, Nom = "Cinema du Parc", DateCreation = new DateTime(2009, 07, 06), NombreSalle=9, Courriel = "cineparc@gmail.com", Telephone = "5142811900", Ville = "Montreal"},
            new () { CinemaId = 7, Nom = "cinema Le Clap Loretteville", DateCreation = new DateTime(1995, 5, 20), NombreSalle=15, Courriel = "cinemaLeClap@gmail.com", Telephone = "4186532470", Ville = "Quebec"},
            new () { CinemaId = 8, Nom = "Cinématheque québécoise", DateCreation = new DateTime(1963, 04, 18), NombreSalle=7, Courriel = "cinemathequeQuebecoise@gmail.com", Telephone = "5148429763", Ville = "Motreal"},
            new () { CinemaId = 9, Nom = "Cinema Fleur de Lys", DateCreation = new DateTime(2000, 8, 4), NombreSalle=15, Courriel = "fleurdelys@gmail.com", Telephone = "8193766154", Ville = "Trois-Rivières"},
            new () { CinemaId = 10, Nom = "cinema des chutes", DateCreation = new DateTime(1998, 1, 4), NombreSalle=9, Courriel = "cinedeschutes@gmail.com", Telephone = "4188315071", Ville = "Saint Nicolas"},
        };
    }
}
