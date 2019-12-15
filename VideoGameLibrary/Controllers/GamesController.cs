using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestSharp;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Controllers
{
    public class GamesController : Controller
    {
        private readonly VideoGameLibraryContext _context;

   
        public GamesController(VideoGameLibraryContext context)
        {
            _context = context;
        }




        // GET: Games
        public async Task<IActionResult> Index(string gameGenre, string searchString)
        {
            //Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from g in _context.Game
                                            orderby g.Genre
                                            select g.Genre;

            var games = from g in _context.Game
                         select g;

            
            if (!String.IsNullOrEmpty(searchString))
            {
                games = games.Where(s => s.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(gameGenre))
            {
                games = games.Where(x => x.Genre == gameGenre);
            }

            var gameGenreVM = new GameGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Games = await games.ToListAsync()
            };

            return View(gameGenreVM);
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Platform,NoOfPlayers,Publisher,BoxArt,Rating,Score,Progress,Summary")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                game = IGDBPost(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET IGDBDetails
        [HttpPost]
        public Game IGDBPost(Game game)
        {


            var client = new RestClient("https://api-v3.igdb.com/games/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "a6b90742-55c3-4d2d-bc3d-5ce9320a7f4a");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Authorization", "Basic Og==");
            request.AddHeader("user-key", "f54f84f7f22567b3d7abdddc4faab01b");
            request.AddParameter("undefined", "fields id,name,summary,rating,rating_count; where name = \"" + game.Title + "\";", ParameterType.RequestBody);
            IRestResponse<List<IGDBRating>> response = client.Execute<List<IGDBRating>>(request);
            if (response.Data.Count > 0)
            {
                game.Rating = response.Data[0].Rating.ToString("#.##");
                game.Summary = response.Data[0].Summary;
            }
            return game;
        }





        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,Platform,NoOfPlayers,Publisher,BoxArt,Rating,Score,Progress,Summary")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.Id == id);
        }
    }
}
