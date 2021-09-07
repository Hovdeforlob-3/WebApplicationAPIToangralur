using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAPIToangralur
{
    public class Room
    {
        public int RoomId { get; set; }
        public int TemperatureInCelsius { get; set; }
        public int LightLevel { get; set; }
        public int SoundLevel { get; set; }
    }
}
