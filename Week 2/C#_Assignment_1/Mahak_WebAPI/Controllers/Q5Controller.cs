using Microsoft.AspNetCore.Mvc;

namespace Mahak_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q5")]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Acknowledges the secret integer passed in the body.
        /// </summary>
        /// <param name="secret">The secret integer.</param>
        /// <returns>A message acknowledging the secret.</returns>
        /// <example>
        /// POST http://localhost:7123/api/q5/secret
        /// Request body: 5
        /// Response: "Shh.. the secret is 5"
        /// </example>
        [HttpPost("secret")]
        public ActionResult<string> PostSecret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
