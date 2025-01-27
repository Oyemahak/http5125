using Microsoft.AspNetCore.Mvc;

namespace Mahak_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q3")]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the integer number.
        /// </summary>
        /// <param name="number">The base number to cube.</param>
        /// <returns>The cube of the number.</returns>
        /// <example>
        /// GET http://localhost:7123/api/q3/cube/4
        /// Response: 64
        /// </example>
        [HttpGet("cube/{number}")]
        public ActionResult<int> GetCube(int number)
        {
            return (int)Math.Pow(number, 3);
        }
    }
}
