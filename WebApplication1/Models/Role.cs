using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SubjectRole> SubjectRoles { get; set; }
    }
}
