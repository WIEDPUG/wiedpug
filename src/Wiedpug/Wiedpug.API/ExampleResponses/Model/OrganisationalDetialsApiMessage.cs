using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Errors;

namespace Wiedpug.API.Model
{

    public class OrganisationDetailsApiMessage
    {
        public string? Message { get; set; }

        public string? WarningCode { get; set; }

        public InformationCode? InformationCode { get; set; }
    }
}
