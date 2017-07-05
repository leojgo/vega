using System.Collections.Generic;

namespace Vega.Models
{
    public class Vehicle : Entity
    {
        public string Name { get; set; }
        public Model Model { get; set; }
        public int Year { get; set; }
        public List<Feature> Features { get; set; }
    }
}