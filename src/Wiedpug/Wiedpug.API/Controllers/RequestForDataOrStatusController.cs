using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wiedpug.API.Controllers
{
    [ApiController]
    [Route("request-for-data-or-status")]
    [Produces("application/json")]
    public class RequestForDataOrStatusController : ControllerBase
    {

        /// <summary>
        /// Retrieves the requested details or status
        /// </summary>
        /// <param name="model">Request payload</param>    
        /// <response code="200">OK - Request has succeeded. Data will be returned if there is any, otherwise, no data will be returned (e.g. No data found in the network or requestor has no access to the record)</response>
        /// <response code="400">Bad Request - Server cannot or will not process the request due to something that is perceived to be a client error (e.g. malformed request syntax, invalid data, etc.).</response>
        /// <response code="401">Unauthorized - Request has not been applied because it lacks valid authentication credentials for the target resource</response>
        /// <response code="403">Forbidden - Server understood the request but refuses to fulfill it.</response>
        /// <response code="500">Internal Server Error - Server encountered an unexpected condition that prevented it from fulfilling the request</response>
        [HttpPost]
        //[ValidateModelState]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(CustomProblemDetails))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(CustomProblemDetails))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(CustomProblemDetails))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(CustomProblemDetails))]        
        [SwaggerRequestExample(typeof(RequestForDataOrStatus), typeof(RequestForDataRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForDataOrStatus200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(RequestForDataOrStatus400Example))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(RequestForDataOrStatus401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(RequestForDataOrStatus403Example))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(RequestForDataOrStatus500Example))]
        public void Post([FromBody] RequestForDataOrStatus model)
        {
        }

    }
}
