using Nest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballApp2.Models;

namespace FootballApp2.Controllers.api
{
    public class TeamsControllerELS:ControllerBase
    {
        private readonly IElasticClient _elasticClient;
        private readonly ILogger<TeamsControllerELS> _logger;

        public TeamsControllerELS(
                            IElasticClient elasticClient,
                            ILogger<TeamsControllerELS> logger)
        {
            _logger = logger;
            _elasticClient = elasticClient;
        }
        [HttpGet("/search/teams")]
        public async Task<IActionResult> Get(string keyword)
        {
            var result = await _elasticClient.SearchAsync<Team>(
                             s => s.Query(
                                 q => q.QueryString(
                                     d => d.Query('*' + keyword + '*')
                                 )).Size(5000));

            _logger.LogInformation("ProductsController Get - ", DateTime.UtcNow);
            return Ok(result.Documents.ToList());
        }

    }
}
