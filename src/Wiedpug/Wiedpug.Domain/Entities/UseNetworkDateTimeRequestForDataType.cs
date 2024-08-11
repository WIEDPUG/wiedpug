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
    public class UseNetworkDateTimeRequestForDataType: IRequestForDataType, IWoolSaleRequestForDataType
    {
        /// <summary>
        /// A boolean value to indicate whether to use network datetime.
        /// 
        /// true: use network datetime.
        /// 
        /// false: not use.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsUsingNetworkDateTime { get; set; }
    }    
}