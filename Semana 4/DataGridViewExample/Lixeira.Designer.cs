﻿namespace DataGridViewExample
{
    partial class Lixeira
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restaurarCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parteFinalLocadoraTSQLDataSet1 = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1();
            this.dataTable1TableAdapter = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1TableAdapters.DataTable1TableAdapter();
            this.clientesTableAdapter1 = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1TableAdapters.ClientesTableAdapter();
            this.locacoesTableAdapter1 = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1TableAdapters.LocacoesTableAdapter();
            this.usuariosTableAdapter1 = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1TableAdapters.UsuariosTableAdapter();
            this.carrosTableAdapter1 = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1TableAdapters.CarrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurarCommandDataGridViewTextBoxColumn,
            this.tabelaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // restaurarCommandDataGridViewTextBoxColumn
            // 
            this.restaurarCommandDataGridViewTextBoxColumn.DataPropertyName = "RestaurarCommand";
            this.restaurarCommandDataGridViewTextBoxColumn.HeaderText = "RestaurarCommand";
            this.restaurarCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restaurarCommandDataGridViewTextBoxColumn.Name = "restaurarCommandDataGridViewTextBoxColumn";
            this.restaurarCommandDataGridViewTextBoxColumn.ReadOnly = true;
            this.restaurarCommandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.restaurarCommandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.restaurarCommandDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabelaDataGridViewTextBoxColumn
            // 
            this.tabelaDataGridViewTextBoxColumn.DataPropertyName = "Tabela";
            this.tabelaDataGridViewTextBoxColumn.HeaderText = "Tabela";
            this.tabelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tabelaDataGridViewTextBoxColumn.Name = "tabelaDataGridViewTextBoxColumn";
            this.tabelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tabelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.parteFinalLocadoraTSQLDataSet1;
            // 
            // parteFinalLocadoraTSQLDataSet1
            // 
            this.parteFinalLocadoraTSQLDataSet1.DataSetName = "ParteFinalLocadoraTSQLDataSet1";
            this.parteFinalLocadoraTSQLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // locacoesTableAdapter1
            // 
            this.locacoesTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // carrosTableAdapter1
            // 
            this.carrosTableAdapter1.ClearBeforeFill = true;
            // 
            // Lixeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 424);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lixeira";
            this.Text = "Lixeira";
            this.Load += new System.EventHandler(this.Lixeira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private ParteFinalLocadoraTSQLDataSet1 parteFinalLocadoraTSQLDataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ParteFinalLocadoraTSQLDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn restaurarCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private ParteFinalLocadoraTSQLDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private ParteFinalLocadoraTSQLDataSet1TableAdapters.LocacoesTableAdapter locacoesTableAdapter1;
        private ParteFinalLocadoraTSQLDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private ParteFinalLocadoraTSQLDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter1;
    }
}