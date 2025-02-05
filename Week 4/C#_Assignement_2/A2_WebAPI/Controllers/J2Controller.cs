using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CSharpAssignment2.Controllers
{
    [ApiController]
    [Route("api/J2")]
    public class J2Controller : ControllerBase
    {
        private readonly Dictionary<string, int> pepperSHU = new Dictionary<string, int>
        {
            { "Poblano", 1500 },
            { "Mirasol", 6000 },
            { "Serrano", 15500 },
            { "Cayenne", 40000 },
            { "Thai", 75000 },
            { "Habanero", 125000 }
        };

        /// <summary>
        /// Calculates the total spiciness of a chili based on the given ingredients.
        /// </summary>
        /// <param name="ingredients">A comma-separated list of pepper names.</param>
        /// <returns>Total Scolville Heat Units (SHU) for the chili.</returns>
        /// <example>
        /// GET /api/J2/ChiliPeppers?ingredients=Poblano,Cayenne,Thai,Poblano
        /// Response: 118000
        /// </example>
        [HttpGet("ChiliPeppers")]
        public int GetSpiciness([FromQuery] string ingredients)
        {
            int totalSHU = 0;
            string[] peppers = ingredients.Split(',');

            foreach (var pepper in peppers)
            {
                if (pepperSHU.ContainsKey(pepper.Trim()))
                {
                    totalSHU += pepperSHU[pepper.Trim()];
                }
            }

            return totalSHU;
        }
    }
}
