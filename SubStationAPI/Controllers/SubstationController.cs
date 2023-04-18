using Microsoft.AspNetCore.Mvc;

namespace SubStationAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SubstationController : ControllerBase
    {

        [HttpGet(Name = "GetCurrentLoad")]
        public double GetCurrentLoad()
        {
            double maximum = 3.0;
            double minimum = 1.5;
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
