using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Note { get; set; }
        public bool Favorite { get; set; }
        //public DateTime Created { get; set; }
        public int ID { get; set; }
        public Color Color { get; set; }
    }
}
