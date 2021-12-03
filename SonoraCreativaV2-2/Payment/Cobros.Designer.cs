namespace SonoraCreativaV2_2.Payment
{
    partial class Cobros
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
            this.buttonPMenu = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.comboBoxIdItemList = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMakeSale = new System.Windows.Forms.Button();
            this.buttonCancelSale = new System.Windows.Forms.Button();
            this.cobrosIdItemListDS = new SonoraCreativaV2_2.CobrosIdItemListDS();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new SonoraCreativaV2_2.CobrosIdItemListDSTableAdapters.inventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosIdItemListDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(141, 37);
            this.buttonPMenu.TabIndex = 26;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = true;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1138, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(141, 37);
            this.buttonLogout.TabIndex = 27;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // listViewItems
            // 
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(12, 124);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(901, 483);
            this.listViewItems.TabIndex = 28;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxIdItemList
            // 
            this.comboBoxIdItemList.DataSource = this.inventarioBindingSource;
            this.comboBoxIdItemList.FormattingEnabled = true;
            this.comboBoxIdItemList.Location = new System.Drawing.Point(919, 137);
            this.comboBoxIdItemList.Name = "comboBoxIdItemList";
            this.comboBoxIdItemList.Size = new System.Drawing.Size(140, 24);
            this.comboBoxIdItemList.TabIndex = 29;
            this.comboBoxIdItemList.Text = "Selecciona un Id...";
            this.comboBoxIdItemList.ValueMember = "id_producto";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1065, 124);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 37);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Añadir Producto";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMakeSale
            // 
            this.buttonMakeSale.Location = new System.Drawing.Point(919, 570);
            this.buttonMakeSale.Name = "buttonMakeSale";
            this.buttonMakeSale.Size = new System.Drawing.Size(141, 37);
            this.buttonMakeSale.TabIndex = 31;
            this.buttonMakeSale.Text = "Realizar Venta";
            this.buttonMakeSale.UseVisualStyleBackColor = true;
            // 
            // buttonCancelSale
            // 
            this.buttonCancelSale.Location = new System.Drawing.Point(1066, 570);
            this.buttonCancelSale.Name = "buttonCancelSale";
            this.buttonCancelSale.Size = new System.Drawing.Size(141, 37);
            this.buttonCancelSale.TabIndex = 32;
            this.buttonCancelSale.Text = "Cancelar Venta";
            this.buttonCancelSale.UseVisualStyleBackColor = true;
            // 
            // cobrosIdItemListDS
            // 
            this.cobrosIdItemListDS.DataSetName = "CobrosIdItemListDS";
            this.cobrosIdItemListDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.cobrosIdItemListDS;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 745);
            this.Controls.Add(this.buttonCancelSale);
            this.Controls.Add(this.buttonMakeSale);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxIdItemList);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPMenu);
            this.Name = "Cobros";
            this.Text = "Realizar Cobros";
            this.Load += new System.EventHandler(this.Cobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cobrosIdItemListDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ComboBox comboBoxIdItemList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMakeSale;
        private System.Windows.Forms.Button buttonCancelSale;
        private CobrosIdItemListDS cobrosIdItemListDS;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private CobrosIdItemListDSTableAdapters.inventarioTableAdapter inventarioTableAdapter;
    }
}