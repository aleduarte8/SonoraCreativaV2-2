namespace SonoraCreativaV2_2.Inventory
{
    partial class InventarioEmpleado
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
            this.groupBoxGridView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInfoProduct = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.inventarioEmpleadosDS = new SonoraCreativaV2_2.InventarioEmpleadosDS();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new SonoraCreativaV2_2.InventarioEmpleadosDSTableAdapters.inventarioTableAdapter();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioEmpleadosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(18, 12);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(141, 37);
            this.buttonPMenu.TabIndex = 25;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = true;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1138, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(141, 37);
            this.buttonLogout.TabIndex = 24;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // groupBoxGridView
            // 
            this.groupBoxGridView.Controls.Add(this.dataGridView1);
            this.groupBoxGridView.Location = new System.Drawing.Point(12, 125);
            this.groupBoxGridView.Name = "groupBoxGridView";
            this.groupBoxGridView.Size = new System.Drawing.Size(1267, 608);
            this.groupBoxGridView.TabIndex = 23;
            this.groupBoxGridView.TabStop = false;
            this.groupBoxGridView.Text = "Seleccione el producto que desea revisar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoproductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 581);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonInfoProduct
            // 
            this.buttonInfoProduct.Location = new System.Drawing.Point(462, 82);
            this.buttonInfoProduct.Name = "buttonInfoProduct";
            this.buttonInfoProduct.Size = new System.Drawing.Size(141, 37);
            this.buttonInfoProduct.TabIndex = 21;
            this.buttonInfoProduct.Text = "Ver Informacion";
            this.buttonInfoProduct.UseVisualStyleBackColor = true;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Location = new System.Drawing.Point(315, 82);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(141, 37);
            this.buttonSearchProduct.TabIndex = 20;
            this.buttonSearchProduct.Text = "Buscar";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(18, 89);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(291, 22);
            this.textBoxSearchProduct.TabIndex = 26;
            this.textBoxSearchProduct.Text = "Buscar producto...";
            // 
            // inventarioEmpleadosDS
            // 
            this.inventarioEmpleadosDS.DataSetName = "InventarioEmpleadosDS";
            this.inventarioEmpleadosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.inventarioEmpleadosDS;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            this.tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            this.tipoproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // InventarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 745);
            this.Controls.Add(this.textBoxSearchProduct);
            this.Controls.Add(this.buttonPMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBoxGridView);
            this.Controls.Add(this.buttonInfoProduct);
            this.Controls.Add(this.buttonSearchProduct);
            this.Name = "InventarioEmpleado";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.InventarioEmpleado_Load);
            this.groupBoxGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioEmpleadosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInfoProduct;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private InventarioEmpleadosDS inventarioEmpleadosDS;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private InventarioEmpleadosDSTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}