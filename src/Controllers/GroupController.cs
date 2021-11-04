using CRUD.EfCore.src.Database;
using CRUD.EfCore.src.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.EfCore.src.Controllers
{
    [ApiController]
    [Route("api/v1/group")]
    public class GroupController 
    {
        private DataContext _context;

        public GroupController(DataContext context)
        {
            this._context = context;
        }


        [HttpPost]
        public async Task<ActionResult<Group>> Create(Group group)
        {

            _context.Groups.Add(group);
            await _context.SaveChangesAsync();

            return group;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Group>> GetById(int id)
        {
            Group group = await _context.Groups.FirstOrDefaultAsync(h => h.Id == id);
            return group;
        }


        [HttpPut()]
        public async Task<ActionResult<Group>> UpdateHero(Group group)
        {
            _context.Groups.Update(group);
            await _context.SaveChangesAsync();

            return group;
        }

        [HttpDelete()]
        public async Task<ActionResult<Group>> DeleteHero(Group group)
        {
            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();

            return group;
        }
    }
}
