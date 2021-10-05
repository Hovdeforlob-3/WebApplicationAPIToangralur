using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class Light_sensor
    {
        [Key]
        public int LightId { get; set; }
        public int LightLevel { get; set; }
        public IList<RoomData> Rooms { get; set; }

    }
}
