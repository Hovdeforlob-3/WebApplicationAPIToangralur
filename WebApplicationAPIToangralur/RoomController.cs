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
        public List<User> Get()
        {
            using (var context = new RoomContext())
            {
                List<User> user = context.User.ToList();
                //List<string> rooms = new List<string>() { "test" };

                return user;
            }
        }

        [HttpGet]
        [Route("Set")]
        public void Set(int temp, int light, int sl)
        {
            using (var context = new RoomContext())
            {
                //var data = new Room { TemperatureInCelsius = temp, LightLevel = light, SoundLevel = sl };
                var data = new RoomData
                {
                    RoomId = "B.16",
                    DateTime = DateTime.Now,
                    Light_Sensor = new Light_sensor { LightLevel = 214 },
                    Gas_Sensor = new Gas_sensor { Co2Level = 500 },
                    Sound_Sensor = new Sound_sensor { SoundLevel = 102 },
                    Motion_Sensor = new Motion_sensor { MotionDetected = false },
                    TemperturHead_Sensor = new Tempertur_sensor { Tempertur = 200, Humidity = 109 },
                    TemperturFoot_Sensor = new Tempertur_sensor { Tempertur = 10, Humidity = 1 }
                };
                context.Room.Add(data);
                context.SaveChanges();
            }
        }
    }
}
