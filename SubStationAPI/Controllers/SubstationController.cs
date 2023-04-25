using Microsoft.AspNetCore.Mvc;
using SubStationAPI.Model;
using SubStationAPI.Service;

namespace SubStationAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SubstationController : ControllerBase
    {
        private readonly ISubstationService _service;
        public SubstationController(ISubstationService service) 
        {
            _service = service;
        }

        [HttpGet(Name = "GetCurrentLoad")]
        public double GetCurrentLoad()
        {
          return  _service.GetLoad();
        }

        [HttpPost(Name = "SetLoad")]
        public void SetCurrentLoad([FromBody] double newload)
        {
            _service.SetLoad(newload);
        }
    }
}
