using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransferConfig
    {
        /// <summary>
        /// Used to identify document transfer type: broadcast or private-sent
        /// Only used for document upload/create/update
        /// </summary>
        ///
        [Required]
        [StringLength(10)]
        public required TransferType TransferType { get; set; }

        /// <summary>
        /// Used to specify included or excluded members for the document transfer
        /// If TransferType is broadcast, it is an exclusion list
        /// If TransferType is private-sent, it is an inclusion list
        /// Should excluded when document is returned to members
        /// </summary>
        /// 
        [Required]
        [StringLength(10)]
        public required List<string> InclusionExclusionList { get; set; }
    }
}
