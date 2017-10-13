using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_Server_Status
{
    public class Server
    {
        public int port;
        public string ip;
        public Server()
        {
        }
        public void setip(string iip)
        {
            ip = iip;
        }
        public void setport(string iport)
        {
            port = Convert.ToInt16(iport);
        }
        public void setport(int iport)
        {
            port = iport;
        }
        public int getport()
        {
            return port;
        }
        public string getip()
        {
            return ip;
        }
        public string getfull()
        {
            return ip +":"+ port;
        }
    }
}
