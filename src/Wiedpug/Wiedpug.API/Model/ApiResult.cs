using System.ComponentModel.DataAnnotations;

namespace Wiedpug.API.Model
{
    /// <summary>
    /// A standard API response object used for all API responses
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Indicator if the request has been successfully processed. 
        /// </summary>
        [Required]        
        public required bool IsSuccessful { get; set; }
        /// <summary>
        /// Contains information about the response if applicable.
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Contains response data. e.g. Auction Catalogue
        /// </summary>
        public object? Data { get; set; }
    }
}
