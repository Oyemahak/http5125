using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment2.Controllers
{
    [ApiController]
    [Route("api/J4")]
    public class J4Controller : ControllerBase
    {
        /// <summary>
        /// Solves a J4 problem from a previous CCC contest year.
        /// </summary>
        /// <param name="input">The input parameter for the problem.</param>
        /// <returns>The computed result based on the problem statement.</returns>
        [HttpPost("Solve")]
        public string SolveJ4Problem([FromBody] string input)
        {
            // TODO: Implement logic for J4 problem here
            return $"Processed input: {input}";
        }
    }
}
