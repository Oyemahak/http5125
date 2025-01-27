using Microsoft.AspNetCore.Mvc;

namespace Mahak_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q4")]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Starts a knock-knock joke.
        /// </summary>
        /// <returns>The first line of the knock-knock joke.</returns>
        /// <example>
        /// POST http://localhost:7123/api/q4/knockknock
        /// Response: "Who’s there?"
        /// </example>
        [HttpPost("knockknock")]
        public ActionResult<string> GetKnockKnockJoke()
        {
            return "Who’s there?";
        }
    }
}
