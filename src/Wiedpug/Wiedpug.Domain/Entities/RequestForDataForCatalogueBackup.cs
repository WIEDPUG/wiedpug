﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class RequestForDataForCatalogueBackup
    {

        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define the types of Catalogue
        /// Only required for request for Catalogue. Not applicable for other documents.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(23)]
        public CatalogueTransmissionType? CatalogueTransmissionType { get; set; }

        /// <summary>
        /// A group field of SellingCentre/Type and Sale Number
        ///
        /// From: The current value that the Sale Identity is to be changed from.
        ///
        /// To: The new value that the Sale Identity is to be changed to.
        ///
        /// SellingCentre/Type can be one of the following code:
        ///
        /// SellingCentre/Type (New Zealand):
        ///
        /// C: Christchurch; N: Napier.
        ///
        /// SellingCentre/Type (Australia):
        ///
        /// A: Adelaide; AU: Australia; B: Brisbane; F: Fremantle; G: Geelong; L: Launceston; M: Melbourne; N: Newcastle; R: Goulburn; S: Sydney; PS: Private Sales; T: Auctions Plus Sales.
        /// </summary>
        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? OrganisationRequested { get; set; }

        public UtcDate? SaleDateRequested { get; set; }

        public UtcDateTime? StartDateTimeStatusRequest { get; set; }

        public UtcDateTime? EndDateTimeStatusRequest { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to use network datetime.
        /// 
        /// true: use network datetime.
        /// 
        /// false: not use.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsUsingNetworkDateTime { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// Cataglogue classes and sub-classes to be excluded in the request.
        /// 
        /// Only required for request for Catalogue. Not applicable for other documents.
        /// 
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(80)]
        public List<ExcludedClass>? ExcludedClasses { get; set; }

        public Season? Season { get; set; }
    }
}
