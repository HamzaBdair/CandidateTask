using API.Domain.Context;
using API.Domain.Models;
using API.Repository.Interfaces;

namespace API.Repository.Repositories
{
    public class CandidateRepository : Repository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(AppDbContext context) : base(context) { }

    }
}
