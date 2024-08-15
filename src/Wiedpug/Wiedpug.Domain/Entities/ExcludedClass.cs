using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    [Description("Cataglouge classes and sub-classes to be excluded in the request. Only required for request for Catalogue.Not applicable for other documents.")]
    public class ExcludedClass
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required ItemsToBeExcluded ClassToBeExcluded { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public SubClassToBeExcluded? SubClassToBeExcluded { get; set; }
    }
}
