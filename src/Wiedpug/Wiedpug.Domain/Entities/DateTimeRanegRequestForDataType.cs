﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class DateTimeRangeRequestForDataType: IRequestForDataType
    {
        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC format. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [Required]
        public required UtcDateTime StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC format. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        public UtcDateTime? EndDateTimeStatusRequest { get; set; }
    }    
}
