using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeInventory
{
    public class Sell
    {
        public bool online_ingame { get; set; }
        public bool online_status { get; set; }
        public string ingame_name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
    }
}
