namespace DataGridViewExample
{
    partial class Form5
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
            this.DeleteCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.carroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parteFinalLocadoraTSQLDataSet1 = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1();
            this.estoqueTableAdapter = new DataGridViewExample.ParteFinalLocadoraTSQLDataSet1TableAdapters.EstoqueTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteCommand,
            this.carroDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // DeleteCommand
            // 
            this.DeleteCommand.DataPropertyName = "DeleteCollum";
            this.DeleteCommand.HeaderText = "Deletar";
            this.DeleteCommand.MinimumWidth = 6;
            this.DeleteCommand.Name = "DeleteCommand";
            this.DeleteCommand.ReadOnly = true;
            this.DeleteCommand.Width = 125;
            // 
            // carroDataGridViewTextBoxColumn
            // 
            this.carroDataGridViewTextBoxColumn.DataPropertyName = "Carro";
            this.carroDataGridViewTextBoxColumn.HeaderText = "Carro";
            this.carroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carroDataGridViewTextBoxColumn.Name = "carroDataGridViewTextBoxColumn";
            this.carroDataGridViewTextBoxColumn.ReadOnly = true;
            this.carroDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.parteFinalLocadoraTSQLDataSet1;
            // 
            // parteFinalLocadoraTSQLDataSet1
            // 
            this.parteFinalLocadoraTSQLDataSet1.DataSetName = "ParteFinalLocadoraTSQLDataSet1";
            this.parteFinalLocadoraTSQLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(658, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 73);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ParteFinalLocadoraTSQLDataSet1 parteFinalLocadoraTSQLDataSet1;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private ParteFinalLocadoraTSQLDataSet1TableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn carroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}