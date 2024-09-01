using API.Domain.Context;
using API.Domain.Models;
using API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpPost("CreateOrUpdateCandidate")]
        public async Task<IActionResult> CreateOrUpdateCandidate([FromBody] Candidate candidate)
        {
            var result = await _candidateService.AddOrUpdateCandidateAsync(candidate);

            if (!result.Success)
            {
                return BadRequest(new { result.Message, result.Errors });
            }

            return Ok(result.Data);
        }
    }
}
