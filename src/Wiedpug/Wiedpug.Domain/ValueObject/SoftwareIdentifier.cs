using System.Runtime.Serialization;

namespace Wiedpug.Domain.ValueObject
{
    public class SoftwareIdentifier
    {
        public string? SoftwareCompany { get; set; }

        /// <summary>
        /// Version no. e.g. 2400
        /// </summary>        
        public int? Version { get; set; }

        public string? ProgramName { get; set; }
    }
}
