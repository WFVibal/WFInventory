using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WarframeInventory
{
    public partial class Inventory : Form
    {
        private List<InventoryItem> _mods = new List<InventoryItem>();
        private List<InventoryItem> _blueprints = new List<InventoryItem>();
        private List<InventoryItem> _relics = new List<InventoryItem>();

        private List<InventoryItem> _ownedMods = new List<InventoryItem>();
        private List<InventoryItem> _ownedBlueprints = new List<InventoryItem>();
        private List<InventoryItem> _ownedRelics = new List<InventoryItem>();

        public Inventory()
        {
            InitializeComponent();
        }

        public void Inventory_Load(object sender, EventArgs e)
        {
            //Generate full inventory list
            string jsonFullList = File.ReadAllText(".\\AllItems.json");
            List<InventoryItem> fullList = JsonConvert.DeserializeObject<List<InventoryItem>>(jsonFullList);
            
            //Parse to object full lists
            foreach(InventoryItem inv in fullList)
            {
                if(inv.item_type == "Blueprint")
                {
                    _blueprints.Add(inv);
                }
                else if(inv.item_type == "Mod")
                {
                    _mods.Add(inv);
                }
                else if(inv.item_type == "Void Relic")
                {
                    _relics.Add(inv);
                }
            }
            _blueprints.Sort((x, y) => x.item_name.CompareTo(y.item_name));
            _mods.Sort((x, y) => x.item_name.CompareTo(y.item_name));
            _relics.Sort((x, y) => x.item_name.CompareTo(y.item_name));
            //Generate owned inventory
            string ownedItemPath = ".\\OwnedItems.json";
            string ownedJsonList = "";

            if (File.Exists(ownedItemPath))
            {
                ownedJsonList = File.ReadAllText(".\\OwnedItems.json");
            }
            else
            {
                File.Create(ownedItemPath);
            }
            
            List<InventoryItem> ownedItemList = JsonConvert.DeserializeObject<List<InventoryItem>>(ownedJsonList);

            if (ownedItemList != null)
            {
                //Parse to owned lists
                foreach (InventoryItem inv in ownedItemList)
                {
                    if (inv.item_type == "Blueprint")
                    {
                        _ownedBlueprints.Add(inv);
                    }
                    else if (inv.item_type == "Mod")
                    {
                        _ownedMods.Add(inv);
                    }
                    else if (inv.item_type == "Void Relic")
                    {
                        _ownedRelics.Add(inv);
                    }
                }
            }
        }

        #region UI Methods
        private void Typeddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Typeddl.SelectedIndex == 0)
            {
                _ownedBlueprints.Sort((x, y) => x.item_name.CompareTo(y.item_name));
                this.InventoryGrid.DataSource = _ownedBlueprints;
                //foreach (InventoryItem item in _ownedBlueprints)
                //{
                //    GetMarketValue(item);

                //    InventoryGrid.Update();
                //    InventoryGrid.Refresh();
                //}
            }
            else if (Typeddl.SelectedIndex == 1)
            {

                _ownedMods.Sort((x, y) => x.item_name.CompareTo(y.item_name));
                this.InventoryGrid.DataSource = _ownedMods;

                //foreach (InventoryItem item in _ownedMods)
                //{
                //    GetMarketValue(item);

                //    InventoryGrid.Update();
                //    InventoryGrid.Refresh();
                //}

            }
            else if (Typeddl.SelectedIndex == 2)
            {
                _ownedRelics.Sort((x, y) => x.item_name.CompareTo(y.item_name));
                this.InventoryGrid.DataSource = _ownedRelics;

                //foreach (InventoryItem item in _ownedRelics)
                //{
                //    GetMarketValue(item);

                //    InventoryGrid.Update();
                //    InventoryGrid.Refresh();
                //}
            }
        }

        private void dataGridDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                string part = "";
                //Delete row. Update totals. Reload Form.
                if (InventoryGrid.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    part = InventoryGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                InventoryItem val = null;

                if(Typeddl.SelectedIndex == 0)
                {
                    //bp delete
                    val = _ownedBlueprints.FirstOrDefault(item => item.item_name == part);
                    _ownedBlueprints.Remove(val);
                }
                else if(Typeddl.SelectedIndex == 1)
                {
                    //Mod delete
                    val = _ownedMods.FirstOrDefault(item => item.item_name == part);
                    _ownedMods.Remove(val);
                }
                else if(Typeddl.SelectedIndex == 2)
                {
                    //Relic delete
                    val = _ownedRelics.FirstOrDefault(item => item.item_name == part);
                    _ownedRelics.Remove(val);
                }

                List<InventoryItem> ownedAll = new List<InventoryItem>();
                ownedAll.AddRange(_ownedMods);
                ownedAll.AddRange(_ownedBlueprints);
                ownedAll.AddRange(_ownedRelics);

                File.WriteAllText(".\\OwnedItems.json", JsonConvert.SerializeObject(ownedAll));

                Inventory reload = new Inventory();
                reload.Show();
                this.Dispose(false);
            }
            else return;
        }
        #endregion

        #region Internal Methods
        private void GetMarketValue(InventoryItem item)
        {
            var req = (HttpWebRequest)WebRequest.Create("http://warframe.market/api/get_orders/");

            if (item.item_type == "Blueprint")
            {
                string url = "http://warframe.market/api/get_orders/Blueprint/" + item.item_name;
                GetMarketValue(url, item);
            }
            else if(item.item_type == "Mod")
            {
                string url = "http://warframe.market/api/get_orders/Mod/" + item.item_name;
                GetMarketValue(url, item);
            }
            else if(item.item_type == "Void Relic")
            {
                string url = "http://warframe.market/api/get_orders/Void%20Relic/" + item.item_name;
                GetMarketValue(url, item);
            }
        }

        private void GetMarketValue(string url, InventoryItem item)
        {
            WebRequest req = WebRequest.Create(url);
            req.ContentType = "application/json; charset=utf-8";
            WebResponse res = req.GetResponse();

            string jsonObj;
            using (Stream responseStream = res.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                jsonObj = reader.ReadToEnd();
            }
            MarketResponse marketObj = JsonConvert.DeserializeObject<MarketResponse>(jsonObj);
            ParseMarketResults(marketObj, item);
        }

        //private async void GetMarketValueAsync(string url, InventoryItem item)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        string responseText;
        //        try
        //        {
        //            responseText = await client.GetStringAsync(url);
        //            MarketResponse marketObj = JsonConvert.DeserializeObject<MarketResponse>(responseText);
        //            ParseMarketResults(marketObj, item);
        //        }
        //        catch(Exception e)
        //        {
        //            if (e.Message.Contains("503"))
        //            {
        //            }
        //        }
        //    }
        //}

        private void ParseMarketResults(MarketResponse marketObj, InventoryItem item)
        {
            int total = 0;
            int count = 0;
            int onlineCount = 0;
            int onlineTotal = 0;
            int? min = null;
            int? max = null;

            foreach (Buy b in marketObj.response.buy)
            {
                count++;
                total += b.price;
                if ((min == null || b.price < min) && b.price > 0)
                {
                    min = b.price;
                }
                if ((max == null || b.price > max) && b.price > 0)
                {
                    max = b.price;
                }
                if (b.online_ingame || b.online_status)
                {
                    onlineCount++;
                    onlineTotal += b.price;
                }
            }

            item.avg_val = (count > 0) ? total / count : 0;
            item.onlineAvg = (onlineCount > 0) ? onlineTotal / onlineCount : 0;
            item.sale_count = count;
            item.min_val = min.GetValueOrDefault();
            item.max_val = max.GetValueOrDefault();
        }


        #endregion

        private void addItembtn_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem(_blueprints, _relics, _mods, _ownedBlueprints, _ownedRelics, _ownedMods, this);
            add.FormClosing += Add_FormClosing;
            add.Show();
            this.Dispose(false);
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Dispose(false);
        }

        public void reload_Form()
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Dispose(false);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (Typeddl.SelectedIndex == 0)
            {
                this.InventoryGrid.DataSource = _ownedBlueprints;
                foreach (InventoryItem item in _ownedBlueprints)
                {
                    GetMarketValue(item);

                    InventoryGrid.Update();
                    InventoryGrid.Refresh();
                }
            }
            else if (Typeddl.SelectedIndex == 1)
            {
                this.InventoryGrid.DataSource = _ownedMods;

                foreach (InventoryItem item in _ownedMods)
                {
                    GetMarketValue(item);

                    InventoryGrid.Update();
                    InventoryGrid.Refresh();
                }

            }
            else if (Typeddl.SelectedIndex == 2)
            {
                this.InventoryGrid.DataSource = _ownedRelics;

                foreach (InventoryItem item in _ownedRelics)
                {
                    GetMarketValue(item);

                    InventoryGrid.Update();
                    InventoryGrid.Refresh();
                }
            }
        }
    }
}
