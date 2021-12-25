using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class PhaseOfContract
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ContractData> ContractDatas { get; set; }
    }
}
