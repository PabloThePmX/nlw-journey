using Journey.Application.UseCases.Trips.GetAll;
using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        [HttpPost]
        //using the "from body" so the endpoint knows it should get the values from the request body
        public IActionResult Register([FromBody]RequestRegisterTripJson request)
        {
            try
            {
                var useCase = new RegisterTripUseCase();

                var response = useCase.Execute(request);

                //status code 201, string empty cuz we arent using URI
                return Created(string.Empty, response);
            }
            catch (JourneyException ex)
            {
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResourceErrorMessages.STATUS_CODE_500);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTripsUseCase();

            var result = useCase.Execute();

            return Ok(result);
        }
    }
}
