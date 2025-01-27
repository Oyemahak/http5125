using Microsoft.AspNetCore.Mvc;

namespace Mahak_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q8")]
    public class Q8Controller : ControllerBase
    {
        private const double SmallPrice = 25.50;
        private const double LargePrice = 40.50;
        private const double TaxRate = 0.13;

        /// <summary>
        /// Returns the checkout summary for a SquashFellows order.
        /// </summary>
        /// <param name="small">The number of small SquashFellows ordered.</param>
        /// <param name="large">The number of large SquashFellows ordered.</param>
        /// <returns>The order summary including price, tax, and total.</returns>
        /// <example>
        /// POST http://localhost:7123/api/q8/squashfellows
        /// Request body: Small=1&Large=1
        /// Response: "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"
        /// </example>
        [HttpPost("squashfellows")]
        public ActionResult<string> PostOrderSummary([FromForm] int small, [FromForm] int large)
        {
            if (small < 0 || large < 0)
            {
                return BadRequest("Small and Large quantities must be non-negative.");
            }

            double subtotal = (small * SmallPrice) + (large * LargePrice);
            double tax = Math.Round(subtotal * TaxRate, 2);
            double total = Math.Round(subtotal + tax, 2);

            return $"{small} Small @ {SmallPrice:C} = {(small * SmallPrice):C}; " +
                   $"{large} Large @ {LargePrice:C} = {(large * LargePrice):C}; " +
                   $"Subtotal = {subtotal:C}; Tax = {tax:C} HST; Total = {total:C}";
        }
    }
}
