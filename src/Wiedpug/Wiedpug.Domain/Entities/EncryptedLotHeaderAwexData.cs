using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Entities
{
    public class EncryptedLotHeaderAwexData
    {
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string EncryptionKeyIdentifier { get; set; }

        /// <summary>
        /// The encrypted LotHeaderAwexData in string format based on base64 encoding.
        /// </summary>
        [Required]
        public required string EncryptedLotHeaderAwexDataString { get; set; }
    }
}
