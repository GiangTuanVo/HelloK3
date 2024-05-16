using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Model
{
    class Account
    {
        public Account(int no, string user, string password)
        {
            No = no;
            User = user;
            Password = password;
        }

        public int No { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{No},{User},{Password}\r\n";
        }
    }
}
