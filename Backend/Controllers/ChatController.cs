using Backend.Logic;
using Backend.Model;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        IChatLogic logic;
        IHubContext<SignalRHub> hub;
        public ChatController(IChatLogic logic, IHubContext<SignalRHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpPost]
        public void Create([FromBody] Chat value)
        {
            logic.Create(value);
            hub.Clients.All.SendAsync("ChatCreated", value);
        }

        [HttpGet]
        public IEnumerable<Chat> ReadAll()
        {
            return logic.ReadAll();
        }
    }
}
