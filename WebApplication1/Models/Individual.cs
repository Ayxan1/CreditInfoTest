using System;
using System.Collections;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Individual
    {
        public int Id { get; set; }        
        public string CustomerCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalID { get; set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public SubjectRole SubjectRole { get; set; }
    }
}
