using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TShirtApi.Api.Data;
using TShirtApi.Api.Models;

namespace TShirtApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TshirtController : ControllerBase
    {
        private readonly Tshirt _context;

        public TshirtController(Tshirt context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Info>> GetAll() =>
            _context.Informations.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<Info>> GetById(long id)
        {
            var product = await _context.Informations.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        [HttpPost]
        public async Task<ActionResult<Info>> Create(Info info)
        {
            _context.Informations.Add(info);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = info.ID }, info);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Info info)
        {
            if (id != info.ID)
            {
                return BadRequest();
            }

            _context.Entry(info).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var product = await _context.Informations.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Informations.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}