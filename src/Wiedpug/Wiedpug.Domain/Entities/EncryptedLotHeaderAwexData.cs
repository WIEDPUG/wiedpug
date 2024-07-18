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

        [Required]
        public required LotHeaderAwexData LotHeaderAwexData { get; set; }
    }
}
