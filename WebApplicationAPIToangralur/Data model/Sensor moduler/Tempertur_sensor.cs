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
        public double Tempertur { get; set; }
        public int Humidity { get; set; }
    }
}
