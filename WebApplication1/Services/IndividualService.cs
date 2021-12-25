using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Threading.Tasks;
using WebApplication1.ApplicationDataContext;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class IndividualService : IIndividualService
    {
        private readonly DataContext dataContext;

        public IndividualService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Individual> Get(string nationalId)
        {
            var result = await dataContext.Individuals.AsNoTracking()
                .Include(i => i.Gender)
                .Include(i => i.Contract)                
                .ThenInclude(c => c.ContractData)
                .ThenInclude(cd => cd.Currency)                          
                .FirstOrDefaultAsync(i => i.NationalID == nationalId);            

            return result;
        }
    }
}
