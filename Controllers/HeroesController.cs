using Microsoft.AspNetCore.Mvc;
using SuperHeros.Services;
using SuperHeros.Models;
using System.Collections.Generic;

namespace SuperHeros.Controllers
{
    public class HeroesController : Controller
    {
        private readonly HeroService _heroService;

        public HeroesController()
        {
            _heroService = new HeroService();
        }

        public IActionResult Index()
        {
            List<Hero> heroes = _heroService.GetHeroes();
            return View(heroes);
        }

        public IActionResult Details(int id)
        {
            List<Hero> heroes = _heroService.GetHeroes();
            var hero = heroes.Find(h => h.Id == id);
            if (hero == null)
            {
                return NotFound();
            }
            return View(hero);
        }
    }
}
