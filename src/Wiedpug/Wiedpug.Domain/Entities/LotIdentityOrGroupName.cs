using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.Entities
{
    public class LotIdentityOrGroupName
    {
        [StringLength(6)]
        public string? LotIdentity {  get; set; }

        [StringLength(6)]
        public string? GrouoName { get; set; }

    }
}
