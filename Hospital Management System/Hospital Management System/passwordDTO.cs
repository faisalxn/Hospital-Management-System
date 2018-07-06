using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class passwordDTO
    {
        private string password;

        public passwordDTO(string password) {
            this.password = password;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
