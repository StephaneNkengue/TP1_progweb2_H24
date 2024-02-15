using Microsoft.AspNetCore.Mvc;
using TP1.Models;
using TP1.ViewModels;

namespace TP1.Controllers
{
    public class FilmsController : Controller
    {
        public IActionResult Index(int? annee)
        {
            if (annee.HasValue)
            {
                var FilmsParAnne = Films.Where(f => f.DateSortie.Year == annee).ToList();
                if (FilmsParAnne == null)
                {
                    return NotFound("404 Not Found");
                }
                return View(FilmsParAnne);
            }

            return View(Films);
        }

        internal static readonly List<Film> Films = new()
        {
            new() { FilmId = 1, Titre = "Inception", DateSortie = new DateTime(2010, 8, 17), Categorie = "Science-fiction, Action", CheminImage = "/Images/Inception.jpg", BudgetRealisation = 160000000 },
            new() { FilmId = 2, Titre = "The Dark Knight", DateSortie = new DateTime(2008, 3, 7), Categorie = "Action, Crime, Drame", CheminImage = "/Images/the_Dark_knight.jpg", BudgetRealisation = 185000000 },
            new() { FilmId = 3, Titre = "Titanic", DateSortie = new DateTime(1997, 11, 19), Categorie = "Drame, Romance", CheminImage = "/Images/Titanic.jpg", BudgetRealisation = 200000000 },
            new() { FilmId = 4, Titre = "Avatar", DateSortie = new DateTime(2009, 8, 9), Categorie = "Science-fiction, Action, Aventure", CheminImage = "/Images/Avatar.jpeg", BudgetRealisation = 237000000 },
            new() { FilmId = 5, Titre = "Interstellar", DateSortie = new DateTime(2014, 1, 17), Categorie = "Science-fiction, Drame, Aventure", CheminImage = "/Images/Interstellar.jpg", BudgetRealisation = 165000000 },
            new() { FilmId = 6, Titre = "Avengers: Endgame", DateSortie = new DateTime(2019, 8, 28), Categorie = " Action, Aventure, Science-fiction", CheminImage = "/Images/Avengers_endGame.jpg", BudgetRealisation = 356000000 },
            new() { FilmId = 7, Titre = "Godfather", DateSortie = new DateTime(1972, 6, 19), Categorie = "Drame, Crime", CheminImage = "/Images/Godfather.jpg", BudgetRealisation = 6000000 },
            new() { FilmId = 8, Titre = "Jurassic Park", DateSortie = new DateTime(1993, 3, 7), Categorie = "Science-fiction, Aventure", CheminImage = "/Images/Jurassic_park.jpg", BudgetRealisation = 63000000 },
            new() { FilmId = 9, Titre = "Harry Potter à l'école des sorciers", DateSortie = new DateTime(2001, 10, 30), Categorie = "Fantastique, Aventure", CheminImage = "/Images/HarryPoter.jpg", BudgetRealisation = 125000000 },
            new() { FilmId = 10, Titre = "Le Seigneur des anneaux : La Communauté de l'anneau", DateSortie = new DateTime(2001, 3, 7), Categorie = " Fantastique, Aventure", CheminImage = "/Images/le_seigneur_des_anneaux.jpg", BudgetRealisation = 93000000 }
        };

        public IActionResult Details(int? id)
        {

            FilmVM? FilmById = Films.Select(
                f => new FilmVM
                {
                    FilmId = f.FilmId,
                    Titre = f.Titre,
                    DateSortie = f.DateSortie,
                    Categorie = f.Categorie
                })
                .FirstOrDefault(f => f.FilmId == id);

            if (FilmById == null)
            {
                return NotFound("404 Not Found");
            }

            return View(FilmById);



        }

    }
}
