using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Errors;

namespace Wiedpug.API.Model
{

    public class ApiMessage
    {
        public string? Message { get; set; }

        public List<WarningCode>? WarningCodes { get; set; }

        public List<InformationCode>? InformationCodes { get; set; }
    }
}
