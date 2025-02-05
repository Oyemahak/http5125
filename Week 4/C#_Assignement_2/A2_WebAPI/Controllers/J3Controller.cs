using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment2.Controllers
{
    [ApiController]
    [Route("api/J3")]
    public class J3Controller : ControllerBase
    {
        /// <summary>
        /// Solves a J3 problem from a previous CCC contest year.
        /// </summary>
        /// <param name="input">The input parameter for the problem.</param>
        /// <returns>The computed result based on the problem statement.</returns>
        [HttpPost("Solve")]
        public string SolveJ3Problem([FromBody] string input)
        {
            // TODO: Implement logic for J3 problem here
            return $"Received input: {input}";
        }
    }
}
