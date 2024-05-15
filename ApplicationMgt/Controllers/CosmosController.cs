
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApplicationMgt.Controllers
{
    [ApiController]
    [Route("cosmos")]
    public class CosmosController : ControllerBase
    {
        private readonly CosmosContext _dbContext;
        private static bool _ensureCreated { get; set; } = false;

        public CosmosController(CosmosContext dbContext)
        {
            _dbContext = dbContext;

            if (!_ensureCreated)
            {
                _dbContext.Database.EnsureCreated();
                _ensureCreated = true;
            }
        }
        
        [HttpGet(Name = "GetQuestion")]
        public async Task<IActionResult> GetQuestion()
        {
            var obj = await _dbContext.Questions.ToListAsync();

            return Ok(obj);
        }
    }
}