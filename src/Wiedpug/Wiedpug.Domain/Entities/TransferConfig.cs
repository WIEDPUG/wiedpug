using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// Used to identify document transfer type: Restrict, Unrestrict, and Exclude.
    /// 
    /// Only used in the request. Do not include it in the response.
    /// </summary>
    public class TransferConfig
    {
        /// <summary>
        /// Used to identify document transfer type: broadcast or private-sent.
        /// 
        /// Only used for document upload/create/update.
        /// </summary>
        ///
        [Required]
        [MinLength(1)]
        [MaxLength(10)]
        public required TransferType TransferType { get; set; }

        public List<Organisation>? FinalReceiverList { get; set; }
    }
}
