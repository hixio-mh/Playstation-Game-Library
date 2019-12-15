using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VideoGameLibrary.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideoGameLibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VideoGameLibraryContext>>()))
            {
                if (context.Game.Any())
                {
                    return; //DB has been seeded
                }


                context.Game.AddRange(
                    new Game
                    {
                        Title = "Persona 5",
                        ReleaseDate = DateTime.Parse("2016-9-15"),
                        Genre = "JRPG",
                        Price = 40.00M,
                        Platform = "Playstation 4",
                        NoOfPlayers = 1,
                        Publisher = "Atlus",
                        BoxArt = "https://upload.wikimedia.org/wikipedia/en/b/b0/Persona_5_cover_art.jpg",
                        Rating = "93%",
                        Score = 9,
                        Progress = 100
                    },

                    new Game
                    {
                        Title = "Marvel's Spider-Man",
                        ReleaseDate = DateTime.Parse("2018-9-7"),
                        Genre = "Action-Adventure",
                        Price = 40.00M,
                        Platform = "Playstation 4",
                        NoOfPlayers = 1,
                        Publisher = "Sony Interactive Entertainment",
                        BoxArt = "https://upload.wikimedia.org/wikipedia/en/e/e1/Spider-Man_PS4_cover.jpg",
                        Rating = "93%",
                        Score = 5,
                        Progress = 25
                    },

                    new Game
                    {
                        Title = "Yakuza 0",
                        ReleaseDate = DateTime.Parse("2017-1-24"),
                        Genre = "Action Adventure",
                        Price = 40.00M,
                        Platform = "Playstation 4",
                        NoOfPlayers = 1,
                        Publisher = "Sega",
                        BoxArt = "https://upload.wikimedia.org/wikipedia/en/b/ba/Yakuza0.jpg",
                        Rating = "93%",
                        Score = 8,
                        Progress = 75
                    },

                    new Game
                    {
                        Title = "Spyro Reignited Trilogy",
                        ReleaseDate = DateTime.Parse("2018-11-13"),
                        Genre = "Platform",
                        Price = 40.00M,
                        Platform = "Playstation 4",
                        NoOfPlayers = 1,
                        Publisher = "Activision",
                        BoxArt = "https://upload.wikimedia.org/wikipedia/en/5/54/Spyro_Reignited_Trilogy.png",
                        Rating = "93%",
                        Score = 7,
                        Progress = 50

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
