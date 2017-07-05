using System.Collections.Generic;

namespace Vega.Models
{
    public class Make : Entity
    {
        public string Name { get; set; }

        public List<Vehicle> Vehicles { get; set; }
       
       
    }
}