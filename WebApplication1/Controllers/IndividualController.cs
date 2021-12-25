using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class IndividualController : ControllerBase
    {
        private readonly IIndividualService individualService;

        public IndividualController(IIndividualService individualService)
        {
            this.individualService = individualService;
        }

        [HttpGet("individuals/{nationalId}")]
        public async Task<IActionResult> Get(string nationalId)
        {
            var result = await individualService.Get(nationalId);

            if(result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
