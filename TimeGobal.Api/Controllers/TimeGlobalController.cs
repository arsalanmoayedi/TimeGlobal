using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeGobal.Api.Services;

namespace TimeGobal.Api.Controllers
{
    [Route("api/timeglobal/{region}")]
    [ApiController]
    public class TimeGlobalController : ControllerBase
    {
        private readonly ITimeGlobalService _timeglobal;
        public TimeGlobalController(ITimeGlobalService timeglobal)
        {
            _timeglobal = timeglobal ?? throw new ArgumentNullException(nameof(timeglobal));
        }
        [HttpGet("{city}")]
        public ActionResult GetTime(string region,string city )
        {
            var showtime = _timeglobal.GetTime(region, city);
            if (showtime==null)
            {
                return BadRequest();
            }
            return Ok(showtime);

        }
    }
}
