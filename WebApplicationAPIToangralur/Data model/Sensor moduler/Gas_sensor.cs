using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class Gas_sensor
    {
        [Key]
        public int GasId { get; set; }
        public int Co2Level { get; set; }

    }
}
