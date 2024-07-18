using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.Entities
{
    public class LotIdentityOrGroupName
    {
        [MinLength(1)]
        [MaxLength(6)]
        public string? LotIdentity {  get; set; }

        [MinLength(1)]
        [MaxLength(6)]
        public string? GroupName { get; set; }

    }
}
