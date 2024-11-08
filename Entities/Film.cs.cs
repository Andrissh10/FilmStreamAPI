using System.IO;

namespace FilmStreamAPI.Entities
{
    public class Film
    {
        public int Id { get; set; }          // Film egyedi azonosítója
        public string Title { get; set; }    // Film címe
        public int Year { get; set; }        // Megjelenés éve
        public int DirectorId { get; set; }  // Kapcsolódás a rendezőhöz
        public Director Director { get; set; } // Rendező objektum
        public int CategoryId { get; set; }  // Kapcsolódás a kategóriához
        public Category Category { get; set; } // Kategória objektum
    }
}
