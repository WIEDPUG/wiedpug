﻿using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Wiedpug.Domain.Errors;

namespace Wiedpug.API.Model
{
    /// <summary>
    /// A machine-readable format for specifying errors in HTTP API responses based on https://tools.ietf.org/html/rfc7807.
    /// </summary>
    public class ApiErrorResult
    {
        /// <summary>
        /// A URI reference [RFC3986] that identifies the problem type.
        /// 
        /// This specification encourages that, when dereferenced, it provide human-readable documentation for the problem type (e.g., using HTML [W3C.REC-html5-20141028]). 
        ///
        /// When this member is not present, its value is assumed to be "about:blank".
        /// 
        /// e.g. For 400 Bad Request, the "type" value can be "https://tools.ietf.org/html/rfc9110#section-15.5.1" 
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// A short, human-readable summary of the problem type.
        /// 
        /// It SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization(e.g., using proactive content negotiation; see[RFC7231], Section 3.4).
        /// 
        /// e.g. "One or more validation errors occurred."        
        /// </summary>
        [Required]
        public required string Title { get; set; }
        /// <summary>
        /// The HTTP status code ([RFC7231], Section 6) generated by the origin server for this occurrence of the problem.
        /// </summary>
        [Required]
        public required int Status { get; set; }
        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem. e.g. 400, 403, or business relared problem etc.
        /// </summary>
        public string? Detail { get; set; }
        /// <summary>
        /// A collection of the erros
        /// </summary>
        public List<CustomError>? Errors { get; set; }
    }
}
