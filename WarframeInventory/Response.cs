using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeInventory
{
    public class Response
    {
        public List<Sell> sell { get; set; }
        public bool render_rank { get; set; }
        public List<Buy> buy { get; set; }
    }
}
