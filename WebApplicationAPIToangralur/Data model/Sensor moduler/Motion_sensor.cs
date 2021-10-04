using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class Motion_sensor
    {
        [Key]
        public int MotionId { get; set; }
        public bool MotionDetected { get; set; }
        public IList<Data> Datas { get; set; }
    }
}
