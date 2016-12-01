using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeInventory
{
    public class InventoryItem
    {
        public string item_type { get; set; }
        public string item_name { get; set; }
        public int? mod_max_rank { get; set; }
        public string rarity { get; set; }
        public string item_wiki { get; set; }
        public string category { get; set; }
        public string wiki_link { get; set; }
        public int quantity { get; set; }
        public int min_val { get; set; }
        public int max_val { get; set; }
        public int avg_val { get; set; }
        public int sale_count { get; set; }
        public int onlineAvg { get; set; }
    }
}
