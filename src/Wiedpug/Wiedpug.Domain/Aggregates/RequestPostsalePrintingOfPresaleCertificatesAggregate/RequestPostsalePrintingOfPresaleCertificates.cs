using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.TextAggregate
{
    public class RequestPostsalePrintingOfPresaleCertificates
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<PrintPreSaleCertificatePostSale> PrintPreSaleCertificatePostSales { get; set; }
    }
}
