using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class RequestForData
    {
        [Required]
        public TransmissionType TransmissionTypeRequested { get; set; }

        public SaleIdentity SaleIdentity { get; set; }

        public string OrgnisationRequested { get; set; }

        /// <summary>
        /// Date and Time with Timezone value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_TIMEZONE_ISO8601)]
        public string StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time with Timezone value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_TIMEZONE_ISO8601)]
        public string EndDateTimeStatusRequest { get; set; }

        public bool? UserNetworkDateTime { get; set; }

        public RequestType RequestType { get; set; }

        public WoolTypeGroup WoolTypeGroup { get; set; }

        public List<RecordType> RecordTypesToBeExcluded { get; set; }

        public int? Season { get; set; }

    }
}
