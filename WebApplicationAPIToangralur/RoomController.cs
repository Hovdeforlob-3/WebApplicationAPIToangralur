using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
/// <summary>
/// connect with ip guide : https://stackoverflow.com/questions/47489168/cannot-access-asp-net-web-api-with-ip-address/50574088
/// </summary>
namespace WebApplicationAPIToangralur
{
    [Route("api/Room")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        // GET: api/<RoomController>
        [HttpGet]
        [Route("Get")]
        public List<Room> Get()
        {
            using (var context = new RoomContext())
            {
                List<Room> rooms = context.Room.ToList();

                return rooms;
            }
        }

        [HttpGet]
        [Route("Set")]
        public void Set(int temp)
        {
            using (var context = new RoomContext())
            {
                var data = new Room { RoomId = 1, TemperatureInCelsius = temp, LightLevel = 30, SoundLevel = 30 };

                context.Room.Add(data);
                context.SaveChanges();
            }
        }
    }
}
