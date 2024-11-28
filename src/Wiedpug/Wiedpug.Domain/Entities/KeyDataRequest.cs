using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class KeyDataRequest
    {
        [Required]
        public required string EncryptionKey { get; set; }

        [Required]
        public required Organisation Organisation { get; set; }
    }
}
