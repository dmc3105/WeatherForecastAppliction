using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherForecastAppliction.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelpController : ControllerBase
    {

        public Dictionary<string, object> help()
        {
            return new Dictionary<string, object> { { "status", "ok" } };
        }
    }
}
