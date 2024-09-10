using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class RequestForData
    {

        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required IRequestForDataType RequestForDataType { get; set; }



        /**
         The following two properties are used for IRequestForDataType "oneOf" relationship referencing when converting to OpenApi.
         Don't delete it here, they will be removed in the openapi converting process.
         The loigc is in Wiedpug.API\SchemaFilter\DiscriminatorFilter.cs
         */

        public UseNetworkDateTimeRequestForDataType? UseNetworkDateTimeRequestForDataType { get; set; }

        public DateTimeRangeRequestForDataType? DateTimeRangeRequestForDataType { get; set; }
    }
}
