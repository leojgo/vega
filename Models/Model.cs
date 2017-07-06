namespace Vega.Models
{
    public class Model : Entity
    {
        public string Name { get; set; }
        public Make Make { get; set; }        
        public long MakeId { get; set; }
    }
}