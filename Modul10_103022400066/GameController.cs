using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400066
{
    [ApiController]
    [Route("api/[controller]")]

    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game> {

                new Game { Id = 1, Name = "Valorant ",Developer = " Riot Games ", TahunRilis = 2020, Genre = "FPS", Rating = 8.5,
                    Platform = new List<string> {"PC"}, Mode = new List<string> {"Multiplayer"}, IsOnline = true, Harga = 250000 },
                new Game { Id = 2, Name = "GTA V",Developer = "Rockstar Games", TahunRilis = 2013, Genre = "Open World", Rating = 9.5,
                    Platform = new List<string> {"PC", "PS4", "PS5", "Xbox"}, Mode = new List<string> {"Singleplayer"}, IsOnline = true, Harga = 300000 },
                new Game { Id = 3, Name = "The Witcher 3",Developer = "CD Project Red ", TahunRilis = 2015, Genre = "RPG", Rating = 9.7,
                    Platform = new List<string> {"PC", "PS4", "PS5", "Xbox", "Switch"}, Mode = new List<string> {"Singleplayer"}, IsOnline = false, Harga = 250000 }
            };

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return games;
        }
        [HttpGet("{id}")]

        public ActionResult<Game> Get(int id)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            return game;
        }

        [HttpPost]

        public IActionResult post([FromBody] Game newGame)
        {
            games.Add(newGame);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= games.Count) return NotFound();
            games.RemoveAt(id);
            return Ok();
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Game updatedGame)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            game.Name = updatedGame.Name;
            game.Developer = updatedGame.Developer;
            game.TahunRilis = updatedGame.TahunRilis;
            game.Genre = updatedGame.Genre;
            game.Rating = updatedGame.Rating;
            game.Platform = updatedGame.Platform;
            game.Mode = updatedGame.Mode;
            game.IsOnline = updatedGame.IsOnline;
            game.Harga = updatedGame.Harga;
            return Ok();
        }
    }
}

    
