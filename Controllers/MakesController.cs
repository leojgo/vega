using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Persistence;
using System.Linq;

namespace Vega.Controllers
{
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly VegaContext _context;
        public MakesController(VegaContext context)
        {
            _context = context;
        }
        
        [HttpGet("/api/makes")]
        public IEnumerable<Make> GetAll()
        {
            return _context.Makes.Include(m => m.Models).ToList();
        }
    }
}