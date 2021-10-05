using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class RoomData
    {
        [Key]
        public string RoomId { get; set; }
        public DateTime DateTime { get; set; }

        public Light_sensor Light_Sensor { get; set; }
        public Sound_sensor Sound_Sensor { get; set; }
        public Gas_sensor Gas_Sensor { get; set; }
        public Motion_sensor Motion_Sensor { get; set; }

        public int LightId { get; set; }
        public int SoundId { get; set; }
        public int GasId { get; set; }
        public int MotionId { get; set; }

    }
}
