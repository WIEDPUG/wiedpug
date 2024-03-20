using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Wiedpug.API.Attributes;
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
        [SwaggerResponse(statusCode: 200, type: typeof(ApiResult), description: "Successful request. Data will be returned if there is, otherwise, no data will be returned (e.g. No data found in the network or requestor has no access to the record)")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiResult), description: "Invalid request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized - login required")]
        [SwaggerResponse(statusCode: 403, description: "Forbidden - lack of permission")]
        public void Post([FromBody] RequestForDataOrStatus model)
        {
        }

    }
}
