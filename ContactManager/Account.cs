﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Contact[] Contacts { get; set; }
    }
}