using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WarframeInventory
{
    public partial class AddItem : Form
    {
        private List<InventoryItem> _blueprints = new List<InventoryItem>();
        private List<InventoryItem> _relics = new List<InventoryItem>();
        private List<InventoryItem> _mods = new List<InventoryItem>();

        private List<InventoryItem> _ownedBlueprints = new List<InventoryItem>();
        private List<InventoryItem> _ownedRelics = new List<InventoryItem>();
        private List<InventoryItem> _ownedMods = new List<InventoryItem>();
        
        private List<InventoryItem> _ownedAll = new List<InventoryItem>();
        private Inventory _parent = null;
        private string _selectedType;

        public AddItem(
            List<InventoryItem> blueprints, 
            List<InventoryItem> relics, 
            List<InventoryItem> mods, 
            List<InventoryItem> ownedBlueprints, 
            List<InventoryItem> ownedRelics, 
            List<InventoryItem> ownedMods,
            Inventory parent)
        {
            _blueprints = blueprints;
            _relics = relics;
            _mods = mods;
            _ownedBlueprints = ownedBlueprints;
            _ownedRelics = ownedRelics;
            _ownedMods = ownedMods;
            _parent = parent;
            InitializeComponent();

            addQuantitytxt.Enabled = false;
            addValueddl.Enabled = false;
        }

        private void addTypeddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(addTypeddl.SelectedIndex == 0)
            {
                //Populate Blueprints
                _selectedType = "bp";
                addValueddl.DataSource = _blueprints;
            }
            if (addTypeddl.SelectedIndex == 1)
            {
                //Populate Mods
                _selectedType = "mod";
                addValueddl.DataSource = _mods;
            }
            if (addTypeddl.SelectedIndex == 2)
            {
                //Populate Relics
                _selectedType = "relic";
                addValueddl.DataSource = _relics;
            }
            addQuantitytxt.Enabled = true;
            addValueddl.Enabled = true;
        }

        private void addValueddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryItem addVal = _ownedBlueprints.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
            InventoryItem addMod = _ownedMods.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
            InventoryItem addRelic = _ownedRelics.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());

            if (_selectedType == "bp" && addVal != null)
            {
                addQuantitytxt.Value = addVal.quantity;
            }
            
            else if (_selectedType == "mod" && addMod != null)
            {
                addQuantitytxt.Value = addMod.quantity;

            }
            
            else if (_selectedType == "Relic" && addRelic != null)
            {
                addQuantitytxt.Value = addRelic.quantity;

            }
            else addQuantitytxt.Value = 0;

        }

        private void addItembtn_Click(object sender, EventArgs e)
        {
            string ownedItemPath = ".\\OwnedItems.json";

            if (!File.Exists(ownedItemPath))
            {
                File.Create(ownedItemPath);
            }
            InventoryItem addVal = null; //_ownedBlueprints.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
            
            if (_selectedType == "bp")
            {
                addVal = _ownedBlueprints.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
                if (addVal != null)
                {
                    InventoryItem val = _ownedBlueprints.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
                    val.quantity = (int)addQuantitytxt.Value;
                }
                else
                {
                    addVal = _blueprints.First(item => item.item_name == addValueddl.SelectedValue.ToString());
                    addVal.quantity = (int)addQuantitytxt.Value;
                    _ownedBlueprints.Add(addVal);
                }
                
            }
            else if (_selectedType == "mod")
            {
                addVal = _ownedMods.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
                if (addVal != null)
                {
                    InventoryItem val = _ownedMods.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
                    val.quantity = (int)addQuantitytxt.Value;
                }
                else
                {
                    addVal = _mods.First(item => item.item_name == addValueddl.SelectedValue.ToString());
                    addVal.quantity = (int)addQuantitytxt.Value;
                    _ownedMods.Add(addVal);
                }
            }
            else
            {
                addVal = _ownedRelics.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
                if (addVal != null)
                {
                    InventoryItem val = _ownedRelics.FirstOrDefault(item => item.item_name == addValueddl.SelectedValue.ToString());
                    val.quantity = (int)addQuantitytxt.Value;
                }
                else
                {
                    addVal = _relics.First(item => item.item_name == addValueddl.SelectedValue.ToString());
                    addVal.quantity = (int)addQuantitytxt.Value;
                    _ownedRelics.Add(addVal);
                }
            }

            _ownedAll.AddRange(_ownedMods);
            _ownedAll.AddRange(_ownedBlueprints);
            _ownedAll.AddRange(_ownedRelics);

            File.WriteAllText(ownedItemPath, JsonConvert.SerializeObject(_ownedAll));

            AddItem reset = new AddItem(_blueprints, _relics, _mods, _ownedBlueprints, _ownedRelics, _ownedMods, _parent);
            reset.FormClosing += Reset_FormClosing;
            reset.Show();
            this.Dispose(false);
        }

        private void Reset_FormClosing(object sender, FormClosingEventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Dispose(false);
        }

        private void addCancelbtn_Click(object sender, EventArgs e)
        {
            AddItem reset = new AddItem(_blueprints, _relics, _mods, _ownedBlueprints, _ownedRelics, _ownedMods, _parent);
            reset.FormClosing += Reset_FormClosing;
            reset.Show();
            this.Dispose(false);
        }
    }
}
