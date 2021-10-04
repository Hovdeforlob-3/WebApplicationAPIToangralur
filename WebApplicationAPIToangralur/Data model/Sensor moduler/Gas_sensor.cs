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
        public bool Co2Level { get; set; }
        public IList<Data> Datas { get; set; }

    }
}
