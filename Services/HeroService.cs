using SuperHeros.Models;
using System.Collections.Generic;

namespace SuperHeros.Services
{
    public class HeroService
    {
        public List<Hero> GetHeroes()
        {
            return new List<Hero>
            {
                new Hero
                {
                    Id = 1,
                    Name = "Superman",
                    ImageUrl = "/images/superman.jpg",
                    Powers = "Super strength, flight, heat vision",
                    ShortDescription = "Man of Steel",
                    FullDescription = "Superman uses his powers to protect the Earth from all kinds of threats."
                },
                 new Hero
                {
                    Id = 2,
                    Name = "Batman",
                    ImageUrl = "/images/bt.jpg",
                    Powers = "Super strength, flight, heat vision",
                    ShortDescription = "Man of Steel",
                    FullDescription = "Superman uses his powers to protect the Earth from all kinds of threats."
                },
                  new Hero
                {
                    Id = 3,
                    Name = "Buru Buri zimon",
                    ImageUrl = "/images/buriburizimon.jpg",
                    Powers = "Super strength, flight, heat vision",
                    ShortDescription = "Man of Steel",
                    FullDescription = "Superman uses his powers to protect the Earth from all kinds of threats."
                },
                   new Hero
                {
                    Id = 4,
                    Name = "Saitama",
                    ImageUrl = "/images/saitama.jpg",
                    Powers = "Super strength, flight, heat vision",
                    ShortDescription = "Man of Steel",
                    FullDescription = "Superman uses his powers to protect the Earth from all kinds of threats."
                },
                new Hero
                {
                    Id = 5,
                    Name = "Action Kamen",
                    ImageUrl = "/images/ak.jpg",
                    Powers = "Super strength, agility, lasso of truth",
                    ShortDescription = "Amazon warrior princess",
                    FullDescription = "Wonder Woman is a fearless Amazon warrior who fights for justice and peace."
                },
                new Hero
                {
                    Id = 6,
                    Name = "Lucky Man",
                    ImageUrl = "/images/Luckyman.jpg",
                    Powers = "Super strength, agility, lasso of truth",
                    ShortDescription = "Amazon warrior princess",
                    FullDescription = "Wonder Woman is a fearless Amazon warrior who fights for justice and peace."
                },
                new Hero
                {
                    Id = 7,
                    Name = "Goku",
                    ImageUrl = "/images/Goku.jpg",
                    Powers = "Super strength, agility, lasso of truth",
                    ShortDescription = "Amazon warrior princess",
                    FullDescription = "Wonder Woman is a fearless Amazon warrior who fights for justice and peace."
                },
                new Hero
                {
                    Id = 8,
                    Name = "Doremon",
                    ImageUrl = "/images/Doremon.jpg",
                    Powers = "Super strength, agility, lasso of truth",
                    ShortDescription = "Amazon warrior princess",
                    FullDescription = "Wonder Woman is a fearless Amazon warrior who fights for justice and peace."
                },
                new Hero
                {
                    Id = 8,
                    Name = "Wonder Woman",
                    ImageUrl = "/images/wonderwoman.jpg",
                    Powers = "Super strength, agility, lasso of truth",
                    ShortDescription = "Amazon warrior princess",
                    FullDescription = "Wonder Woman is a fearless Amazon warrior who fights for justice and peace."
                }
            };
        }
    }
}
