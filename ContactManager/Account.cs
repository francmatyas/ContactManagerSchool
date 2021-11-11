using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
