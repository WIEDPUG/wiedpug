using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System.Net;
using Wiedpug.API.Attributes;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wiedpug.API.Controllers
{    
    [Route("request-for-data-or-status")]    
    [ApiController]
    public class RequestForDataOrStatusController : ControllerBase
    {

        // POST api/<RequestForDataOrStatusController>
        [HttpPost]
        [ValidateModelState]        
        [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(ApiResult), description: "Successful request. Data will be returned if there is, otherwise, no data will be returned (e.g. No data found in the network or requestor has no access to the record)")]
        [SwaggerResponse(statusCode: StatusCodes.Status400BadRequest, type: typeof(ApiResult), description: "Invalid request")]
        [SwaggerResponse(statusCode: StatusCodes.Status401Unauthorized, description: "Unauthorized - login required")]
        [SwaggerResponse(statusCode: StatusCodes.Status403Forbidden, description: "Forbidden - lack of permission")]
        [SwaggerRequestExample(typeof(RequestForDataOrStatus), typeof(RequestForDataRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForDataOrStatus200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(RequestForDataOrStatus400Example))]        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]        
        public void Post([FromBody] RequestForDataOrStatus model)
        {
        }

    }
}
