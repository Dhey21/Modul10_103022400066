namespace Modul10_103022400066
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public int TahunRilis { get; set; }
        public string Genre { get; set; }   
        public double Rating { get; set; }
        public List<string> Platform { get; set; }
        public List<string>  Mode { get; set; }
        public bool IsOnline { get; set; }
        public int Harga { get; set; }

        public Game()
        {

        }

        public Game(int id, string name, string developer, int tahunRilis, string genre, double rating, List<string> platform, List<string> mode, bool isOnline, int harga)
        {
            Id = id;
            Name = name;
            Developer = developer;
            TahunRilis = tahunRilis;
            Genre = genre;
            Rating = rating;
            Platform = platform;
            Mode = mode;
            IsOnline = isOnline;
            Harga = harga;
        }
   
        
        }

    }

