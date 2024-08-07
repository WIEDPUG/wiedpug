using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.TestCertificateAggregate
{
    public class TestCertificates
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// 
        /// Should only be required for document upload/create/update.
        /// 
        /// Should be excluded when returning document to members.
        /// </summary>
        public TransferConfig? TransferConfig { get; set; }

        [Required]
        public required List<TestCertificate> TestCertificateCollection { get; set; }
    }
}
