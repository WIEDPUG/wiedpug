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
    [Route("api/[controller]")]
    [ApiController]
    public class RequestForDataOrStatusController : ControllerBase
    {

        // POST api/<RequestForDataOrStatusController>
        [HttpPost]
        [ValidateModelState]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(ApiResult), description: "Successful request. Data will be returned if there is, otherwise, no data will be returned (e.g. No data found in the network or requestor has no access to the record)")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.BadRequest, type: typeof(ApiResult), description: "Invalid request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized - login required")]
        [SwaggerResponse(statusCode: 403, description: "Forbidden - lack of permission")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(RequestForDataOrStatus200Example))]
        [SwaggerResponseExample((int)HttpStatusCode.BadRequest, typeof(RequestForDataOrStatus400Example))]
        [SwaggerRequestExample(typeof(RequestForDataOrStatus), typeof(RequestForDataRequestExample))]
        public void Post([FromBody] RequestForDataOrStatus model)
        {
        }

    }
}
