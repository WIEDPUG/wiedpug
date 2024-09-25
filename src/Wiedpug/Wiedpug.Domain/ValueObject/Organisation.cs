using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    /// <summary>
    /// A code used to identify organisations involved in the wool trade.
    /// 
    /// These codes are issued and maintained by the Network and are available online.
    /// 
    /// currentReceiver: The code for the organisation that will receive the document at the end of the current transmission.Where a document is transferred from one
    /// organisation to another through an intermediary, the code for the current receiver will vary from leg to leg of the journey.
    /// 
    /// releasingOrganisation: The broker that is responsible for releasing the wool out of the store.
    /// 
    /// markingOrganisation: The code for the organisation which is to apply marks to the bales.
    /// 
    /// invoicingOrganisation: The code for the broker who will raise the invoice for the wool.
    /// 
    /// storageOrganisation: This is the organisation store that is storing the wool. Note: If there is more than one organisation in a centre, then separate AWEX codes are 
    /// required for each store. It is not necessarily the same as the Releasing Organisation.
    /// 
    /// client: The code for the organisation that is the transmitter’s client. Where one organisation submits a TRV document to a Test House requesting tests 
    /// for one of its own clients, the code for that client will be used in this field.
    /// </summary>
    public class Organisation
    {
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public required string OrganisationCode { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public Centre? Centre { get; set; }
    }
}
