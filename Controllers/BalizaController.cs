using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_base.Models;

namespace Api_base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalizaController : ControllerBase
    {
        private readonly BalizaContext _context;

        public BalizaController(BalizaContext context)
        {
            _context = context;
        }

        // GET: api/Baliza
        [Autohorrize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Balizas>>> GetBalizas()
        {
            return await _context.Balizas.ToListAsync();
        }

        // GET: api/Baliza/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Balizas>> GetBalizas(string id)
        {
            var balizas = await _context.Balizas.FindAsync(id);

            if (balizas == null)
            {
                return NotFound();
            }

            return balizas;
        }

       
        private bool BalizasExists(string id)
        {
            return _context.Balizas.Any(e => e.Municipio == id);
        }
    }
}
