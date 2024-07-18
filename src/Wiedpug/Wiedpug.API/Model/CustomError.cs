using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Errors;

namespace Wiedpug.API.Model
{

    public class CustomErrors
    {
        /// <summary>
        /// Dictionary of errors in &lt;PropertyName, ErrorDetails[]&gt; format. e.g. errors: { "name": ["Product name is required"], "category": ["Category name cannot be longer than 20 characters."]  }
        /// </summary>
        public Dictionary<string, string[]>? Errors { get; set; }

        public List<ErrorCode>? ErrorCodes { get; set; }
    }
}
