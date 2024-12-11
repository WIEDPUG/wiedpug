using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class KeyDataRequest
    {
        /// <summary>
        /// A string representation of a JSON web key. JSON web key ref: https://datatracker.ietf.org/doc/html/rfc7517
        /// 
        /// Example: '{\"alg\": \"RS256\",\"kty\": \"RSA\",\"use\": \"enc\",\"x5c\": [\"MIIC+DCCAeCgAwIBAgIJBIGjYW6hFpn2MA…2sc2mlq1i3IashGkkgmo=\"],\"n\": \"yeNlzlub94YgerT030codqEztjfU…W3HoBdjQ\",\"e\": \"AQAB\",\"kid\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\",\"x5t\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\"}'
        /// </summary>
        [Required]
        public required string EncryptionKey { get; set; }

        [Required]
        public required Organisation Organisation { get; set; }
    }
}
