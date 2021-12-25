using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ContractData> ContractDatas { get; set; }
        public ICollection<SubjectRole> SubjectRoles { get; set; }
    }
}
