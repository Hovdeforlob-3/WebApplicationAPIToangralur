﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPIToangralur
{
    public class User
    {
        [Key]
        public string  Username { get; set; }
        public string Password { get; set; }

    }
}
