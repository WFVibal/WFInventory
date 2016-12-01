using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WFIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var req = (HttpWebRequest)WebRequest.Create("http://warframe.market/api/get_orders/Blueprint/Saryn%20Prime%20Blueprint");
            req.ContentType = "text/json";
            req.Method = "GET";
            string jsonRes;

            var res = (HttpWebResponse)req.GetResponse();
            using (var rdr = new System.IO.StreamReader(res.GetResponseStream(), ASCIIEncoding.ASCII))
            {
                jsonRes = rdr.ReadToEnd();
            }
                Console.Write(jsonRes);
        }
    }
}
