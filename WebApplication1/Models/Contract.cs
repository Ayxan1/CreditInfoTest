using System.Collections;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string ContractCode { get; set; }

        public ContractData ContractData { get; set; }
        public ICollection<Individual> Individuals { get; set; }
    }
}
