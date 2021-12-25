using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Individual> Individuals { get; set; }
    }
}
