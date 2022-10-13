using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using SignallRHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//using Microsoft.AspNetCore.SignalR.Client;

namespace SignallRHub.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IHubContext<BroadcastHub, IHubClient> _hubContext;
        public HomeController(IHubContext<BroadcastHub, IHubClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet]
        public async Task<IActionResult> BroadcastMessage(string Message)
        {
            if (String.IsNullOrEmpty(Message))
            {
                return BadRequest();
            }
            await _hubContext.Clients.All.BroadcastMessage(Message);
            return NoContent();

        }


        [HttpPost]
        public QRDetails test()
        {
            return new QRDetails();
        }

        //[HttpGet]
        //public async Task<IActionResult> BroadcastBusLocation(string RouteCode, string StationCode, string BusNumber, string Direction)
        //{
        //    if (String.IsNullOrEmpty(RouteCode) || String.IsNullOrEmpty(StationCode) || String.IsNullOrEmpty(BusNumber) || String.IsNullOrEmpty(Direction))
        //    {
        //        return BadRequest();
        //    }
        //    await _hubContext.Clients.All.BroadcastBusLocation(RouteCode,StationCode,BusNumber,Direction);
        //    return Ok();

        //}



        //public Task JoinGroup(string GroupName)
        //{
        //    return _hubContext.Groups.AddToGroupAsync(HttpContext.Connection.Id,GroupName);
        //}

        //public Task SendMessageToGroup(string GroupName, string Message)
        //{
        //    return _hubContext.Clients.Group(GroupName).SendMessageToGroup("Received Message", Message);
        //}


























    }
}
