using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SimpleIPLogger
{
    class IPLogger
    {
        public static string GetIp()
        {
            string ip = new WebClient().DownloadString("http://ip-api.com/line/");
            return ip;
        }
    }
}
