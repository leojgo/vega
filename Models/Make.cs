using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Models
{
    public class Make : Entity
    {
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
       
       public Make()
       {
           Models = new Collection<Model>();
       }
       
    }
}