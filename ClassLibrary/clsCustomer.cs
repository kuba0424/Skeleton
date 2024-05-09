using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class clsCustomer
    {
        public bool Active { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
