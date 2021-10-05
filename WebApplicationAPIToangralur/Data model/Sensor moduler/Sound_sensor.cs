using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class Sound_sensor
    {
        [Key]
        public int SoundId { get; set; }
        public int SoundLevel { get; set; }
        public IList<RoomData> Rooms { get; set; }

    }
}
