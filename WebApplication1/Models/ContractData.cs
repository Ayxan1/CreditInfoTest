using System;

namespace WebApplication1.Models
{
    public class ContractData
    {
        public int Id { get; set; }        
        public decimal OriginalAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal CurrentBalanceId { get; set; }
        public decimal OverdueBalance { get; set; }
        public DateTime DateOfLastPayment { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public DateTime DateAccountOpened { get; set; }
        public DateTime RealEndDate { get; set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int PhaseOfContractId { get; set; }
        public PhaseOfContract PhaseOfContract { get; set; }
    }
}
