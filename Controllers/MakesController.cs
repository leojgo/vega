using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Persistence;
using System.Linq;
using AutoMapper;
using vega.Controllers.Resources;

namespace Vega.Controllers
{
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly VegaContext _context;
        private readonly IMapper mapper;
        public MakesController(VegaContext context, IMapper mapper)
        {
            this.mapper = mapper;
            _context = context;
        }

        [HttpGet("/api/makes")]
        public IEnumerable<MakeResource> GetAll()
        {
            var makes = _context.Makes.Include(m => m.Models).ToList();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}