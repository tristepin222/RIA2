using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Analyser.API.Services;
using Analyser.API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Analyser.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyserController : ControllerBase
    {
        // POST api/<AnalyserController>
        [HttpPost]
        public async Task<IImageData> Post([FromBody] ImageParams data)
        {
            GoogleLabelDetectorImpl analyser = new GoogleLabelDetectorImpl();
            return await analyser.Analyze(data.RemoteFullPath, data.MaxLabels, data.MinConfidenceLevel);
        }
    }
}
