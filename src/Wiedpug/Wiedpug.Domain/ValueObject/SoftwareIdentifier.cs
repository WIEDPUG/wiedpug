using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class SoftwareIdentifier
    {
        [StringLength(1)]
        public string? SoftwareCompany { get; set; }

        /// <summary>
        /// Version no. e.g. 2400
        /// </summary>      
        /// 
        [StringLength(4)]
        [RegularExpression(Regex.NUMBERS)]
        public int? Version { get; set; }

        [StringLength(4)]
        public string? ProgramName { get; set; }
    }
}
