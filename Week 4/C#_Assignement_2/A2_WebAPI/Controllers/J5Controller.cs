using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment2.Controllers
{
    [ApiController]
    [Route("api/J5")]
    public class J5Controller : ControllerBase
    {
        /// <summary>
        /// Solves a J5 problem from a previous CCC contest year.
        /// </summary>
        /// <param name="input">The input parameter for the problem.</param>
        /// <returns>The computed result based on the problem statement.</returns>
        [HttpPost("Solve")]
        public string SolveJ5Problem([FromBody] string input)
        {
            // TODO: Implement logic for J5 problem here
            return $"Computed result: {input}";
        }
    }
}
