using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Errors;

namespace Wiedpug.API.Model
{

    public class ApiMessage
    {
        /// <summary>
        /// A code to indicate the different types of errors.
        /// 
        /// 11: Weight Note suffix is not numeric or has been omitted.
        /// 
        /// 12: Number of bales is invalid or has been omitted.
        /// 
        /// 13: Sale identification has been omitted.
        /// 
        /// 18: Invalid Gross weight.
        /// 
        /// 19: Invalid Tare weight.
        /// 
        /// 20: Invalid Centre/Client code on pre-sale test request.
        /// 
        /// 24: Incorrect PCTR Hash total.
        /// 
        /// DRV: Dark and Medullated Fibre Risk error.
        /// </summary>
        public string? WarningMessage { get; set; }

        public string? WarningCode { get; set; }

        public InformationCode? InformationCode { get; set; }
    }
}
