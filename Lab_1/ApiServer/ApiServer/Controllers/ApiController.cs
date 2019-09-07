using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiServer.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiServer.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PhoneController : ControllerBase
    {
        //(GET, POST, DELETE, PUT, OPTION)
        private readonly PhoneContext _context;

        public PhoneController(PhoneContext context)
        {
            _context = context;
        }
        
        // GET: api/Phone
        [HttpGet]
        [EnableCors]
        public async Task<ActionResult<IEnumerable<Phone>>> GetPhones()
        {
            return await _context.Phones.ToListAsync();
           
        }

        // GET: api/Phone/2
        [HttpGet("{id}")]
        [EnableCors]
        public async Task<ActionResult<Phone>> GetPhone(int id)
        {
            var todoItem = await _context.Phones.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }
        
        // POST: api/Phone
        [HttpPost]
        [EnableCors]
        public async Task<ActionResult<Phone>> PostPhone(Phone phone)
        {
            _context.Phones.Add(phone);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPhone), new { id = phone.Id }, phone);
        }
        
        // PUT: api/Phone/5
        [HttpPut("{id}")]
        
        public async Task<IActionResult> PutPhone(int id, Phone phone)
        {
            if (id != phone.Id)
            {
                return BadRequest();
            }

            _context.Entry(phone).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Phone/5
        [HttpDelete("{id}")]
        [EnableCors]
        public async Task<IActionResult> DeletePhone(int id)
        {
            var todoItem = await _context.Phones.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }
            _context.Phones.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        
        // HttpOptions: api/Phone
        [HttpOptions]
        [EnableCors("AllowMyOrigin")]
        public async Task<IActionResult> OptionsPhone()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", new[] { (string)Request.Headers["Origin"] });
            Response.Headers.Add("Access-Control-Allow-Headers", new[] { "Origin, X-Requested-With, Content-Type, Accept" });
            Response.Headers.Add("Access-Control-Allow-Methods", new[] {"GET, POST, PUT, DELETE, OPTIONS"});
            Response.Headers.Add("Allow", new[] {"GET, POST, PUT, DELETE, OPTIONS"});
            Response.Headers.Add("Access-Control-Allow-Credentials", new[] { "true" });
            return NoContent();
        }
    }
}