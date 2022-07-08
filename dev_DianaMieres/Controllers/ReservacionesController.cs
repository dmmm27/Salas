using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dev_DianaMieres.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace dev_DianaMieres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionesController : ControllerBase
    {
        private readonly ReservaSalasContext _context;

        public ReservacionesController(ReservaSalasContext context)
        {
            _context = context;
        }

        // GET: api/Reservaciones
        [HttpGet]
        /* public async Task<ActionResult<IEnumerable<Reservacione>>> GetReservaciones()
         {
            // return await _context.Reservaciones.ToListAsync();
         }*/

        public async Task<ActionResult<IEnumerable<HorasDisponibles>>> GetReservaciones(string status)
        {
          
            return await _context.Set<HorasDisponibles>()
                     .FromSqlRaw("exec ingresoReservas {0},{1},{2},{3}", null, null, null, status)
                    .ToArrayAsync();

        }


        // GET: api/Reservaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservacione>> GetReservacione(int id)
        {
            var reservacione = await _context.Reservaciones.FindAsync(id);

            if (reservacione == null)
            {
                return NotFound();
            }

            return reservacione;
        }

        // PUT: api/Reservaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservacione(int id, Reservacione reservacione)
        {
            if (id != reservacione.Id)
            {
                return BadRequest();
            }

            _context.Entry(reservacione).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservacioneExists(id))
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

        // POST: api/Reservaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public JsonResult PostReservacione(IngresoReservacion reservacione)
        {


            try
            {
                _context.Database
                       .ExecuteSqlRaw("exec ingresoReservas {0},{1},{2},{3}", reservacione.horaInicio, reservacione.HoraFin, reservacione.idSala, reservacione.status);

            }
            catch (Exception ex)
            {
                // BadRequest(ex.Message);

                return new JsonResult(ex.Message);
            }
          
            return new JsonResult("Added ingresoReservas");
        }

        // DELETE: api/Reservaciones/5
        [HttpDelete]
        public JsonResult DeleteReservacione(EliminarReservacion reservacione)
        {
            try
            {
                _context.Database
                       .ExecuteSqlRaw("exec ingresoReservas {0},{1},{2},{3}", reservacione.horaInicio, null,null,  reservacione.status);

            }
            catch (Exception ex)
            {
                // BadRequest(ex.Message);

                return new JsonResult(ex.Message);
            }

            return new JsonResult("deleted");
        }

        private bool ReservacioneExists(int id)
        {
            return _context.Reservaciones.Any(e => e.Id == id);
        }
    }
}
