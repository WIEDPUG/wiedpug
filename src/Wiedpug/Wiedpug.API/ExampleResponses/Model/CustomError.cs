using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Errors;

namespace Wiedpug.API.Model
{

    public class CustomError
    {
        /// <summary>
        /// Dictionary of errors in &lt;PropertyName, ErrorDetails[]&gt; format. e.g. errors: { "name": ["Product name is required"], "category": ["Category name cannot be longer than 20 characters."]  }
        /// </summary>
        public Dictionary<string, string[]>? Errors { get; set; }

        public string? ErrorMessage { get; set; }

        /// <summary>
        /// The error code is defined by business rules to indicate the different types of errors.
        /// 
        /// Examples of error code:
        ///  
        /// DOXCT: Document originator does not match current transmitter."
        ///
        /// INVTC: Invalid transfer config. All data rejected."
        /// 
        /// INVFR: Invalid/missing FinalReceiverList record. All data rejected."
        ///
        /// INVAC: Invalid sale aann/nn dd/mm/yy ooooo. All data rejected."
        /// 
        /// INVCR: Current receiver not awtm. All data rejected."
        /// 
        /// INVDO: Invalid document originator code aaaaa. Data accepted."
        /// 
        /// INVSO: Warning! Invalid selling org AAAAA using doc orig AAAAA."
        /// 
        /// INVEX: Invalid excluded record."
        /// </summary>
        public string? ErrorCode { get; set; }
    }
}
