using DataObject.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DataObject.API.Controllers
{
    public class DataObjectController
    {
        [ApiController]
        [Route("api/v1/[controller]")]
        public class ShoppingController : ControllerBase
        {

            [HttpPost]
            public async void Upload([FromBody] ImageParams data)
            {
                await GoogleDataObjectImpl.Upload(data.localFullPath, data.remoteFullPath);
            }

            [HttpPost]
            public async Task<string> Publish([FromBody] ImageParams data)
            {
                return await GoogleDataObjectImpl.Publish(data.remoteFullPath, data.expirationTime);
            }

        }
    }
}
