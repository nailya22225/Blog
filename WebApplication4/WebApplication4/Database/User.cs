﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Database
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int NumberOfPublication { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City{ get; set; }
        public int Years { get; set; }

    }
}
