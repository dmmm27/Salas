using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dev_DianaMieres.Models;

namespace dev_DianaMieres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListadoReservacionesController : ControllerBase
    {
        private readonly ReservaSalasContext _context;

        public ListadoReservacionesController(ReservaSalasContext context)
        {
            _context = context;
        }

        // GET: api/ListadoReservaciones
        /* [HttpGet]
         public async Task<ActionResult<IEnumerable<ListadoReservaciones>>> GetListadoReservaciones()
         {
             return await _context.ListadoReservaciones.ToListAsync();
         }*/

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListadoReservaciones>>> GetListadoReservaciones(string status)
        {

            return await _context.Set<ListadoReservaciones>()
                     .FromSqlRaw("exec ingresoReservas {0},{1},{2},{3}", null, null, null, status)
                    .ToArrayAsync();

        }

        // GET: api/ListadoReservaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListadoReservaciones>> GetListadoReservaciones(int id)
        {
            var listadoReservaciones = await _context.ListadoReservaciones.FindAsync(id);

            if (listadoReservaciones == null)
            {
                return NotFound();
            }

            return listadoReservaciones;
        }

        // PUT: api/ListadoReservaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListadoReservaciones(int id, ListadoReservaciones listadoReservaciones)
        {
            if (id != listadoReservaciones.Id)
            {
                return BadRequest();
            }

            _context.Entry(listadoReservaciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListadoReservacionesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ListadoReservaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListadoReservaciones>> PostListadoReservaciones(ListadoReservaciones listadoReservaciones)
        {
            _context.ListadoReservaciones.Add(listadoReservaciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListadoReservaciones", new { id = listadoReservaciones.Id }, listadoReservaciones);
        }

        // DELETE: api/ListadoReservaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListadoReservaciones(int id)
        {
            var listadoReservaciones = await _context.ListadoReservaciones.FindAsync(id);
            if (listadoReservaciones == null)
            {
                return NotFound();
            }

            _context.ListadoReservaciones.Remove(listadoReservaciones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListadoReservacionesExists(int id)
        {
            return _context.ListadoReservaciones.Any(e => e.Id == id);
        }
    }
}
