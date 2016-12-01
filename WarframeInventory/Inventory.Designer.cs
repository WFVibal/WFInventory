namespace WarframeInventory
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Typeddl = new System.Windows.Forms.ComboBox();
            this.Typelbl = new System.Windows.Forms.Label();
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.addItembtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.inventoryItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Typeddl
            // 
            this.Typeddl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Typeddl.FormattingEnabled = true;
            this.Typeddl.Items.AddRange(new object[] {
            "Blueprint",
            "Mod",
            "Relic"});
            this.Typeddl.Location = new System.Drawing.Point(151, 12);
            this.Typeddl.Name = "Typeddl";
            this.Typeddl.Size = new System.Drawing.Size(263, 21);
            this.Typeddl.TabIndex = 0;
            this.Typeddl.Text = "Please select a value";
            this.Typeddl.SelectedIndexChanged += new System.EventHandler(this.Typeddl_SelectedIndexChanged);
            // 
            // Typelbl
            // 
            this.Typelbl.AutoSize = true;
            this.Typelbl.Location = new System.Drawing.Point(22, 15);
            this.Typelbl.Name = "Typelbl";
            this.Typelbl.Size = new System.Drawing.Size(37, 13);
            this.Typelbl.TabIndex = 1;
            this.Typelbl.Text = "Type: ";
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AllowUserToOrderColumns = true;
            this.InventoryGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.avg_Value,
            this.max_Value,
            this.min_Value,
            this.onlineAvg,
            this.sale_count,
            this.delCol});
            this.InventoryGrid.DataSource = this.inventoryItemBindingSource1;
            this.InventoryGrid.Location = new System.Drawing.Point(11, 39);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.Size = new System.Drawing.Size(919, 405);
            this.InventoryGrid.TabIndex = 2;
            this.InventoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDelete_CellContentClick);
            // 
            // addItembtn
            // 
            this.addItembtn.Location = new System.Drawing.Point(711, 472);
            this.addItembtn.Name = "addItembtn";
            this.addItembtn.Size = new System.Drawing.Size(108, 23);
            this.addItembtn.TabIndex = 3;
            this.addItembtn.Text = "Add Items";
            this.addItembtn.UseVisualStyleBackColor = true;
            this.addItembtn.Click += new System.EventHandler(this.addItembtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(822, 472);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(108, 23);
            this.Updatebtn.TabIndex = 4;
            this.Updatebtn.Text = "Update Prices";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // inventoryItemBindingSource1
            // 
            this.inventoryItemBindingSource1.DataSource = typeof(WarframeInventory.InventoryItem);
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity Owned";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // avg_Value
            // 
            this.avg_Value.DataPropertyName = "avg_val";
            this.avg_Value.HeaderText = "Value (Avg.)";
            this.avg_Value.Name = "avg_Value";
            this.avg_Value.ReadOnly = true;
            this.avg_Value.Width = 95;
            // 
            // max_Value
            // 
            this.max_Value.DataPropertyName = "max_val";
            this.max_Value.HeaderText = "Value (Max)";
            this.max_Value.Name = "max_Value";
            this.max_Value.ReadOnly = true;
            this.max_Value.Width = 95;
            // 
            // min_Value
            // 
            this.min_Value.DataPropertyName = "min_val";
            this.min_Value.HeaderText = "Value (Min)";
            this.min_Value.Name = "min_Value";
            this.min_Value.ReadOnly = true;
            this.min_Value.Width = 95;
            // 
            // onlineAvg
            // 
            this.onlineAvg.DataPropertyName = "onlineAvg";
            this.onlineAvg.HeaderText = "Online (Avg.)";
            this.onlineAvg.Name = "onlineAvg";
            this.onlineAvg.Width = 95;
            // 
            // sale_count
            // 
            this.sale_count.DataPropertyName = "sale_count";
            this.sale_count.HeaderText = "Searched Sales";
            this.sale_count.Name = "sale_count";
            this.sale_count.Width = 125;
            // 
            // delCol
            // 
            this.delCol.HeaderText = " ";
            this.delCol.Name = "delCol";
            this.delCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delCol.Text = "Delete";
            this.delCol.UseColumnTextForButtonValue = true;
            this.delCol.Width = 45;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 507);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.addItembtn);
            this.Controls.Add(this.InventoryGrid);
            this.Controls.Add(this.Typelbl);
            this.Controls.Add(this.Typeddl);
            this.Name = "Inventory";
            this.Text = "Warframe Inventory Management";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Typeddl;
        private System.Windows.Forms.Label Typelbl;
        private System.Windows.Forms.DataGridView InventoryGrid;
        private System.Windows.Forms.Button addItembtn;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_count;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
    }
}

