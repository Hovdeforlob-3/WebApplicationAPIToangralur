using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;


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
        [ApikeyAuth]
        [HttpGet]
        [Route("Get")]
        public List<RoomData> Get()
        {
            using (var context = new RoomContext())
            {
                var rooms = context.Room
                    .Include(gas => gas.Gas_Sensor)
                    .Include(light => light.Light_Sensor)
                    .Include(sound => sound.Sound_Sensor)
                    .Include(motion => motion.Motion_Sensor)
                    .Include(tempH => tempH.TemperturHead_Sensor)
                    .Include(tempF => tempF.TemperturFoot_Sensor)
                    .ToList();

                return rooms;
            }

        }

        [ApikeyAuth]
        [HttpGet]
        [Route("Set")]
        public void Set(string roomId, int light, int co2, int sound, bool motion, double tempH, double tempF,
            int humiH, int humiF)
        {
            using (var context = new RoomContext())
            {
                var data = new RoomData
                {
                    RoomId = roomId,
                    DateTime = DateTime.Now,
                    Light_Sensor = new Light_sensor {LightLevel = light},
                    Gas_Sensor = new Gas_sensor {Co2Level = co2},
                    Sound_Sensor = new Sound_sensor {SoundLevel = sound},
                    Motion_Sensor = new Motion_sensor {MotionDetected = motion},
                    TemperturHead_Sensor = new Tempertur_sensor {Tempertur = tempH, Humidity = humiH},
                    TemperturFoot_Sensor = new Tempertur_sensor {Tempertur = tempF, Humidity = humiF}
                };
                context.Room.Add(data);
                context.SaveChanges();
            }
        }


        //[ApikeyAuth]
        [HttpGet]
        [Route("User")]
        public UserResponde CheckUser(string name, string password)
        {
            using (var context = new RoomContext())
            {
                var users = context.User.ToList();

                foreach (var item in users)
                {
                    if (name == item.Username && password == item.Password)
                    {
                        var Valid = new UserResponde { Id = 1, StatusCode = "200 ok" };
                        return Valid;
                    }
                }
                var notValid = new UserResponde { Id = 1, StatusCode = "401 not ok" };
                return notValid;
            }
        }
    }
}
