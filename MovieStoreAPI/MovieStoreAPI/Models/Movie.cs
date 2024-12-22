namespace MovieStoreAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string PosterImage { get; set; } // Base64 string
    }
}
