using CRUD.EfCore.src.Database;
using CRUD.EfCore.src.Dto;
using CRUD.EfCore.src.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUD.EfCore.src.Controllers
{
    [ApiController]
    [Route("api/v1/heros")]
    public class HeroController
    {

        private DataContext _context;

        public HeroController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public HeroDTO Create(HeroDTO hero)
        {
            Hero newHero = new Hero(hero);

            _context.Heroes.Add(newHero);
            _context.SaveChanges();

            return hero;
        }

        [HttpGet("{id:int}")]
        public Hero GetById(int id)
        {
            Hero hero = _context.Heroes.FirstOrDefault(h => h.Id == id);
            return hero;
        }
        
    }
}