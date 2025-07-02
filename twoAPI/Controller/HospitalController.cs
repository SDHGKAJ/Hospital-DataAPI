using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using twoAPI.Model;
namespace twoAPI.Controller
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HospitalController:ControllerBase
    {
        private readonly AppDbContext _context;
        public HospitalController (AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [HttpPost]
        [HttpPost]
        public async Task<ActionResult<people>> AddPeople([FromBody] people People)
        {
            _context.hospital.Add(People);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPeople), new { id = People.Id }, People);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<people>> GetPeople(int id)
        {
            var person = await _context.hospital.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeople(int id)
        {
            var person = await _context.hospital.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.hospital.Remove(person);
            await _context.SaveChangesAsync();
            return NoContent(); // 204 status
        }



    }
}
