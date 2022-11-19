using ConnectFourApp.Server.Data;
using ConnectFourApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConnectFourApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlayerController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var plyrs = await _context.Players.ToListAsync();
            return Ok(plyrs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var plyr = await _context.Players.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(plyr);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Player player)
        {
            _context.Add(player);
            await _context.SaveChangesAsync();
            return Ok(player.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var plyr = new Player { Id = id };
            _context.Remove(plyr);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}