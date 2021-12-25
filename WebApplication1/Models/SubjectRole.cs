namespace WebApplication1.Models
{
    public class SubjectRole
    {
        public int Id { get; set; }        
        public decimal? GuaranteeAmount { get; set; }

        public int IndividualId { get; set; }
        public Individual Individual { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int? CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
