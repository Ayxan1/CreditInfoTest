using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IIndividualService
    {
        public Task<Individual> Get(string nationalId);
    }
}
