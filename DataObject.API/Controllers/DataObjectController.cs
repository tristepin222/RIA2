using DataObject.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

using DataObject.API.Models;
namespace DataObject.API.Controllers
{
    public class DataObjectController
    {
        [ApiController]
        [Route("api/v1/[controller]")]
        public class ShoppingController : ControllerBase
        {

            [HttpPost]
            public async void Upload([FromBody] DataObjectParam data)
            {

                await GoogleDataObjectImpl.Upload(data.LocalFullPath, data.RemoteFullPath);
            }

            [HttpPost]
            public async Task<string> Publish([FromBody] DataObjectParam data)
            {
                return await GoogleDataObjectImpl.Publish(data.RemoteFullPath, data.ExpirationTime);
            }

        }
    }
}
