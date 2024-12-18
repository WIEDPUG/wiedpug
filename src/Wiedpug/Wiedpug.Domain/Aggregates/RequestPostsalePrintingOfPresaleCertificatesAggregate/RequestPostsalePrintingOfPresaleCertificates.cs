using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.TextAggregate
{
    public class RequestPostsalePrintingOfPresaleCertificates
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// </summary>
        [Required]
        public required TransferConfig TransferConfig { get; set; }

        [Required]
        public required List<PrintPreSaleCertificatePostSale> PrintPreSaleCertificatePostSales { get; set; }
    }
}
