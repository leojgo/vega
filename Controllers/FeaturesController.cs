using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using vega.Controllers.Resources;
using Vega.Models;
using Vega.Persistence;

namespace vega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IMapper mapper;
        private readonly VegaContext context;
        public FeaturesController(VegaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public IEnumerable<FeatureResource> GetFeatures()
        {
            var features = context.Features.ToList();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}