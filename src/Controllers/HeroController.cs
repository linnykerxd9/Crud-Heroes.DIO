using CRUD.EfCore.src.Database;
using CRUD.EfCore.src.Dto;
using CRUD.EfCore.src.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<ActionResult<Hero>> Create( HeroDTO hero)
        {
            Hero newHero = new Hero(hero);

            _context.Heroes.Add(newHero);
            await _context.SaveChangesAsync();

            return newHero;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Hero>> GetById( int id)
        {
            Hero hero = await _context.Heroes.FirstOrDefaultAsync(h => h.Id == id);
            return hero;
        }

       
        [HttpPut()]
        public async Task<ActionResult<Hero>> UpdateHero( Hero hero)
        {
            _context.Heroes.Update(hero);
            await _context.SaveChangesAsync();

            return hero;
        }

        [HttpDelete()]
        public async Task<ActionResult<Hero>> DeleteHero( Hero hero)
        {
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();

            return hero;
        }
    }
}