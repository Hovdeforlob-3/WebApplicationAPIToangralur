using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class Tempertur_sensor
    {
        [Key]
        public int TemperturId { get; set; }
        public bool Tempertur { get; set; }
        public IList<RoomTempatur> RoomTempatur { get; set; }
    }
}
