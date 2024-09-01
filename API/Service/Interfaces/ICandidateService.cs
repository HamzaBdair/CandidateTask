using API.Domain.Models;

namespace API.Service.Interfaces
{
    public interface ICandidateService
    {
        Task<ResponseResult<Candidate>> AddOrUpdateCandidateAsync(Candidate candidate);
    }
}
