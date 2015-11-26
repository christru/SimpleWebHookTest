using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using WebHook.Models;

namespace WebHook.Controllers
{
    public class WebHookController : ApiController
    {

        public string Get()
        {
            return "send events here";
        }


        [HttpPost]
        public async Task<Message> Post()
        {
            string contentBody;
            var message = new Message();

            contentBody = await Request.Content.ReadAsStringAsync();
            message.ClientAddress = HttpContext.Current.Request.UserHostAddress;
            message.ContentBody = contentBody;
            ProgressHub.SendMessage(JsonConvert.SerializeObject(message));

            return message;
        }
    }
}
