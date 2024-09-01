using System.ComponentModel.DataAnnotations;

namespace API.Domain.Models
{
    public class Candidate
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]    
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PreferredCallStartTime { get; set; } 
        public string? PreferredCallEndTime { get; set; }
        public string? LinkedInProfileUrl { get; set; }
        public string? GitHubProfileUrl { get; set; }
        [Required(ErrorMessage = "Notes is required.")]
        public string Notes { get; set; }
    }
}
