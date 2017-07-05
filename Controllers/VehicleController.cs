using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vega.Models;

namespace Vega.Controllers
{
    [Route("api/vehicles")]
    public class VehicleController : Controller
    {
        private readonly VegaContext _context;

        public VehicleController(VegaContext context)
        {
            _context = context;
        }

        [HttpGet("api/vehicles")]
        public IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles.ToList();
        }
    }
}