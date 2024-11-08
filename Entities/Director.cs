namespace FilmStreamAPI.Entities
{
    public class Director
    {
        public int Id { get; set; }           // Rendező egyedi azonosítója
        public string Name { get; set; }      // Rendező neve
        public DateTime DateOfBirth { get; set; } // Születési dátum
    }
}
