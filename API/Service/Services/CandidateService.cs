using API.Domain.Models;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }


        public async Task<ResponseResult<Candidate>> AddOrUpdateCandidateAsync(Candidate candidate)
        {
            

                var existingCandidate = await _candidateRepository.GetByIdAsync(candidate.Id);
 
            

            if (existingCandidate != null)
            {
                existingCandidate.FirstName = candidate.FirstName;
                    existingCandidate.LastName = candidate.LastName;
                existingCandidate.Email = candidate.Email;
                existingCandidate.PhoneNumber = candidate.PhoneNumber;
                existingCandidate.PreferredCallStartTime = candidate.PreferredCallStartTime;
                existingCandidate.PreferredCallEndTime = candidate.PreferredCallEndTime;
                existingCandidate.LinkedInProfileUrl = candidate.LinkedInProfileUrl;
                existingCandidate.GitHubProfileUrl = candidate.GitHubProfileUrl;

                _candidateRepository.Update(existingCandidate);
            }
            else
            {
                await _candidateRepository.AddAsync(candidate);
            }

            return new ResponseResult<Candidate> { Data = candidate };
        }
    }
}
