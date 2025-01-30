using Microsoft.AspNetCore.Mvc;

namespace Mahak_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q2")]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting to the specified name.
        /// </summary>
        /// <param name="name">The name to greet.</param>
        /// <returns>A greeting message.</returns>
        /// <example>
        /// GET http://localhost:7123/api/q2/greeting?name=Gary
        /// Response: "Hi Gary!"
        /// </example>
        [HttpGet("greeting")]
        public string GetGreeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}
