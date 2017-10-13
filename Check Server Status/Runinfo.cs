using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_Server_Status
{
    public class Runinfo
    {
        public Runinfo()
        {
        }
        public string location,username,password,full;
        public string getfull()
        {
            full = username + " " + password;
            return full;
        }
    }
}
