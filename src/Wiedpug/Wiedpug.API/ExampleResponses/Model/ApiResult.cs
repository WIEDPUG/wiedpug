using System.ComponentModel.DataAnnotations;

namespace Wiedpug.API.Model
{
    /// <summary>
    /// A standard API response object used for all successful API responses
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Contains information about the response if applicable.
        /// </summary>
        public List<ApiMessage>? ApiMessages { get; set; }
        
        /// <summary>
        /// Contains response data.
        /// </summary>
        public object? Data { get; set; }
    }

    /// <summary>
    /// A standard API response object used for all successful API responses
    /// </summary>
    public class ApiResult<T>
    {
        /// <summary>
        /// Contains information about the response if applicable.
        /// </summary>
        public List<ApiMessage>? ApiMessages { get; set; }
        /// <summary>
        /// Contains response data.
        /// </summary>
        public T? Data { get; set; }
    }
}
