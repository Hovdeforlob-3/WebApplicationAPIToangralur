using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPIToangralur
{
    public class RoomTempatur
    {
        public RoomData Rooms { get; set; }
        public Tempertur_sensor Tempertur_Sensor { get; set; }

        [Key]
        [Column(Order = 1)]
        public int RoomId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TemperturId { get; set; }
    }
}
