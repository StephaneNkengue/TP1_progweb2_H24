namespace TP1.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Titre { get; set; }
        public DateTime DateSortie { get; set; }
        public string Categorie { get; set; }
        public string CheminImage { get; set; }
        public double BudgetRealisation { get; set; }
    }
}
