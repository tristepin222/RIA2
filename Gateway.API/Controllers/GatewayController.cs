using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Gateway.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : ControllerBase
    {
        private HttpClient httpClient;
        [HttpPost]
        public async void Call()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.example.com/");

            var task = GoogleDataObjectImpl.DoesExists(imageName);
            task.Wait();
            if (!task.Result)
            {
                var taskUpload = GoogleDataObjectImpl.Upload(imageName, imageName);
                taskUpload.Wait();
            }
        }
        [HttpPost]
        public async Task<string> Publish(string remoteFullPath, int expirationTime = 90)
        {
            return await GoogleDataObjectImpl.Publish(remoteFullPath, expirationTime);
        }
        [HttpPost]
        public async Task<JsonResult> Analyze(string remoteFullPath, int maxLabels = 10, int minConfidenceLevel = 90)
        {
            GoogleLabelDetectorImpl analyser = new GoogleLabelDetectorImpl();

            IImageData img = await analyser.Analyze(remoteFullPath, maxLabels, minConfidenceLevel);
            SQLDumber.Dumb(img);
            return img;
        }
        [HttpPost]
        public async void Upload(string localFullPath, string remoteFullPath)
        {
            await GoogleDataObjectImpl.Upload(localFullPath, remoteFullPath);
        }
    }
}
