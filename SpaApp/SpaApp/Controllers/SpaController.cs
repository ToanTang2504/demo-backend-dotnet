using Microsoft.AspNetCore.Mvc;
using SpaApp.Models;

namespace SpaApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpaController : ControllerBase
    {
        private readonly ILogger<SpaController> _logger;

        public SpaController(ILogger<SpaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/spa/get-content-data")]
        public SpaContent GetContentData()
        {
            SpaContent result = new SpaContent()
            {
                AboutInfos = MockData.GetAboutInfo().ToArray(),
                FeatureBoxes = MockData.GetFeatureBoxes().ToArray(),
                Counters = MockData.GetCounters().ToArray(),
                Sliders = MockData.GetSliders().ToArray(),
                Tabs = MockData.GetTabs().ToArray(),
                TabNavs = MockData.GetTabNavs().ToArray()
            };
            return result;
        }
    }
}
