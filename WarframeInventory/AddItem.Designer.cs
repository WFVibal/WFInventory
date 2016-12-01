namespace WarframeInventory
{
    partial class AddItem
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
            this.addTypeddl = new System.Windows.Forms.ComboBox();
            this.addValueddl = new System.Windows.Forms.ComboBox();
            this.inventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addTypelbl = new System.Windows.Forms.Label();
            this.addValuelbl = new System.Windows.Forms.Label();
            this.addQuantitylbl = new System.Windows.Forms.Label();
            this.addItembtn = new System.Windows.Forms.Button();
            this.addCancelbtn = new System.Windows.Forms.Button();
            this.addQuantitytxt = new System.Windows.Forms.NumericUpDown();
            this.inventoryItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantitytxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // addTypeddl
            // 
            this.addTypeddl.FormattingEnabled = true;
            this.addTypeddl.Items.AddRange(new object[] {
            "Blueprint",
            "Mod",
            "Relic"});
            this.addTypeddl.Location = new System.Drawing.Point(121, 13);
            this.addTypeddl.Name = "addTypeddl";
            this.addTypeddl.Size = new System.Drawing.Size(292, 21);
            this.addTypeddl.TabIndex = 0;
            this.addTypeddl.Text = "Please select a value";
            this.addTypeddl.SelectedIndexChanged += new System.EventHandler(this.addTypeddl_SelectedIndexChanged);
            // 
            // addValueddl
            // 
            this.addValueddl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addValueddl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addValueddl.DataSource = this.inventoryItemBindingSource2;
            this.addValueddl.DisplayMember = "item_name";
            this.addValueddl.FormattingEnabled = true;
            this.addValueddl.Location = new System.Drawing.Point(121, 41);
            this.addValueddl.Name = "addValueddl";
            this.addValueddl.Size = new System.Drawing.Size(292, 21);
            this.addValueddl.TabIndex = 1;
            this.addValueddl.ValueMember = "item_name";
            this.addValueddl.SelectedIndexChanged += new System.EventHandler(this.addValueddl_SelectedIndexChanged);
            // 
            // inventoryItemBindingSource
            // 
            this.inventoryItemBindingSource.DataSource = typeof(WarframeInventory.InventoryItem);
            // 
            // addTypelbl
            // 
            this.addTypelbl.AutoSize = true;
            this.addTypelbl.Location = new System.Drawing.Point(16, 16);
            this.addTypelbl.Name = "addTypelbl";
            this.addTypelbl.Size = new System.Drawing.Size(31, 13);
            this.addTypelbl.TabIndex = 2;
            this.addTypelbl.Text = "Type";
            // 
            // addValuelbl
            // 
            this.addValuelbl.AutoSize = true;
            this.addValuelbl.Location = new System.Drawing.Point(16, 44);
            this.addValuelbl.Name = "addValuelbl";
            this.addValuelbl.Size = new System.Drawing.Size(34, 13);
            this.addValuelbl.TabIndex = 3;
            this.addValuelbl.Text = "Value";
            // 
            // addQuantitylbl
            // 
            this.addQuantitylbl.AutoSize = true;
            this.addQuantitylbl.Location = new System.Drawing.Point(16, 74);
            this.addQuantitylbl.Name = "addQuantitylbl";
            this.addQuantitylbl.Size = new System.Drawing.Size(46, 13);
            this.addQuantitylbl.TabIndex = 4;
            this.addQuantitylbl.Text = "Quantity";
            // 
            // addItembtn
            // 
            this.addItembtn.Location = new System.Drawing.Point(257, 117);
            this.addItembtn.Name = "addItembtn";
            this.addItembtn.Size = new System.Drawing.Size(75, 23);
            this.addItembtn.TabIndex = 6;
            this.addItembtn.Text = "Add";
            this.addItembtn.UseVisualStyleBackColor = true;
            this.addItembtn.Click += new System.EventHandler(this.addItembtn_Click);
            // 
            // addCancelbtn
            // 
            this.addCancelbtn.Location = new System.Drawing.Point(338, 117);
            this.addCancelbtn.Name = "addCancelbtn";
            this.addCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.addCancelbtn.TabIndex = 7;
            this.addCancelbtn.Text = "Cancel";
            this.addCancelbtn.UseVisualStyleBackColor = true;
            this.addCancelbtn.Click += new System.EventHandler(this.addCancelbtn_Click);
            // 
            // addQuantitytxt
            // 
            this.addQuantitytxt.Location = new System.Drawing.Point(121, 72);
            this.addQuantitytxt.Name = "addQuantitytxt";
            this.addQuantitytxt.Size = new System.Drawing.Size(292, 20);
            this.addQuantitytxt.TabIndex = 8;
            // 
            // inventoryItemBindingSource1
            // 
            this.inventoryItemBindingSource1.DataSource = typeof(WarframeInventory.InventoryItem);
            // 
            // inventoryItemBindingSource2
            // 
            this.inventoryItemBindingSource2.DataSource = typeof(WarframeInventory.InventoryItem);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 157);
            this.Controls.Add(this.addQuantitytxt);
            this.Controls.Add(this.addCancelbtn);
            this.Controls.Add(this.addItembtn);
            this.Controls.Add(this.addQuantitylbl);
            this.Controls.Add(this.addValuelbl);
            this.Controls.Add(this.addTypelbl);
            this.Controls.Add(this.addValueddl);
            this.Controls.Add(this.addTypeddl);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantitytxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addTypeddl;
        private System.Windows.Forms.ComboBox addValueddl;
        private System.Windows.Forms.Label addTypelbl;
        private System.Windows.Forms.Label addValuelbl;
        private System.Windows.Forms.Label addQuantitylbl;
        private System.Windows.Forms.Button addItembtn;
        private System.Windows.Forms.Button addCancelbtn;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource;
        private System.Windows.Forms.NumericUpDown addQuantitytxt;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource2;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource1;
    }
}