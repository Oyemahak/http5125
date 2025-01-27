using Microsoft.AspNetCore.Mvc;

namespace Mahak_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q7")]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns a date adjusted by the specified number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust the current date by.</param>
        /// <returns>The adjusted date as a string in yyyy-MM-dd format.</returns>
        /// <example>
        /// GET http://localhost:7123/api/q7/timemachine?days=1
        /// Response: 2000-01-02
        /// </example>
        [HttpGet("timemachine")]
        public ActionResult<string> GetAdjustedDate([FromQuery] int days)
        {
            var adjustedDate = DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
            return adjustedDate;
        }
    }
}
