using System.Runtime.Serialization;

namespace Wiedpug.Domain.ValueObject
{
    public class SoftwareIdentifier
    {
        /// <summary>
        /// Gets or Sets SoftwareCompany
        /// </summary>

        [DataMember(Name = "softwareCompany")]
        public string SoftwareCompany { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>

        [DataMember(Name = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets ProgramName
        /// </summary>

        [DataMember(Name = "programName")]
        public string ProgramName { get; set; }
    }
}
