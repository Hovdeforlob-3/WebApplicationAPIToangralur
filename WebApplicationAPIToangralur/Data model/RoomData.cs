using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPIToangralur
{
    public class RoomData
    {
        [Key]
        public DateTime DateTime { get; set; }
        public string RoomId { get; set; }

        public Light_sensor Light_Sensor { get; set; }
        public Sound_sensor Sound_Sensor { get; set; }
        public Gas_sensor Gas_Sensor { get; set; }
        public Motion_sensor Motion_Sensor { get; set; }


        public virtual Tempertur_sensor TemperturHead_Sensor { get; set; }
        public virtual Tempertur_sensor TemperturFoot_Sensor { get; set; }

    }
}
